using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RealmOffline;
using System.Reflection;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Threading;
using RealmOffline.Core;

namespace RealmOfflineWorldServer.Core.Scripting
{
    public static class CSharpCompiler
    {
        public static string OutputPath = Path.Combine(ServerGlobals.BaseDirectory, "Scripts\\Scripts.dll");
        public static bool Debug = false;
        private static int mItems = 0;
        private static int mMobile = 0; 
        private readonly static List<string> mAdditionalReferences = new List<string>();

        private static Assembly[] mAssemblies;

        public static Assembly[] Assemblies
        {
            get
            {
                return mAssemblies;
            }
            set
            {
                mAssemblies = value;
            }
        }

        public static void Compile(string[] files)
        {
            Console.Write("Scripts: Compiling C# scripts...");

            if (files.Length == 0)
            {
                Console.WriteLine("no files found.");
            }
            using (CSharpCodeProvider provider = new CSharpCodeProvider())
            {

                CompilerParameters parms = new CompilerParameters(GetReferenceAssemblies(), OutputPath, Debug);
                CompilerResults results = provider.CompileAssemblyFromFile(parms, files);
                Display(results);
            }
        }
        public static string[] GetReferenceAssemblies()
        {
            List<string> list = new List<string>();

            string path = Path.Combine(ServerGlobals.BaseDirectory, "Data/Assemblies.cfg");


            if (File.Exists(path))
            {
                using (StreamReader ip = new StreamReader(path))
                {
                    string line;

                    while ((line = ip.ReadLine()) != null)
                    {
                        if (line.Length > 0 && !line.StartsWith("#"))
                            list.Add(line);
                    }
                }
            }

            list.Add(ServerGlobals.ExePath);

            list.AddRange(mAdditionalReferences);

            return list.ToArray();
        }
        public static string[] GetScriptReferences(string[] files)
        {
            List<string> assemblies = new List<string>();
            foreach (string file in files)
            {
                IEnumerable<string> lines = File.ReadLines(file);
                foreach (string line in lines)
                {
                    if (line.StartsWith("using"))
                    {
                        string output = line;
                        output = output.Remove(0, 6); // removes using [space]
                        output = output.Split(';').First() + ".dll";
                        if(!assemblies.Contains(output))assemblies.Add(output);
                    }
                }
            }
            return assemblies.ToArray();
        }
        public static string[] GetScripts(string filter)
        {
            List<string> list = new List<string>();

            GetScripts(list, Path.Combine(ServerGlobals.BaseDirectory, "Scripts"), filter);

            return list.ToArray();
        }

        public static void GetScripts(List<string> list, string path, string filter)
        {
            foreach (string dir in Directory.GetDirectories(path))
                GetScripts(list, dir, filter);

            list.AddRange(Directory.GetFiles(path, filter));
        }
        public static string GetCompilerOptions(bool debug)
        {
            StringBuilder sb = null;

            if (!debug)
                AppendCompilerOption(ref sb, "/optimize");

#if MONO
			AppendCompilerOption( ref sb, "/d:MONO" );
#endif

            //These two defines are legacy, ie, depreciated.
            if (Environment.Is64BitOperatingSystem)
                AppendCompilerOption(ref sb, "/d:x64");

            AppendCompilerOption(ref sb, "/d:Framework_4_0");

            return (sb == null ? null : sb.ToString());
        }
        private static void AppendCompilerOption(ref StringBuilder sb, string define)
        {
            if (sb == null)
                sb = new StringBuilder();
            else
                sb.Append(' ');

            sb.Append(define);
        }
        public static void Display(CompilerResults results)
        {
            if (results.Errors.Count > 0)
            {
                Dictionary<string, List<CompilerError>> errors = new Dictionary<string, List<CompilerError>>(results.Errors.Count, StringComparer.OrdinalIgnoreCase);
                Dictionary<string, List<CompilerError>> warnings = new Dictionary<string, List<CompilerError>>(results.Errors.Count, StringComparer.OrdinalIgnoreCase);

                foreach (CompilerError e in results.Errors)
                {
                    string file = e.FileName;

                    // Ridiculous. FileName is null if the warning/error is internally generated in csc.
                    if (string.IsNullOrEmpty(file))
                    {
                        Console.WriteLine("ScriptCompiler: {0}: {1}", e.ErrorNumber, e.ErrorText);
                        continue;
                    }

                    Dictionary<string, List<CompilerError>> table = (e.IsWarning ? warnings : errors);

                    List<CompilerError> list = null;
                    table.TryGetValue(file, out list);

                    if (list == null)
                        table[file] = list = new List<CompilerError>();

                    list.Add(e);
                }

                if (errors.Count > 0)
                    Console.WriteLine("failed ({0} errors, {1} warnings)", errors.Count, warnings.Count);
                else
                    Console.WriteLine("done ({0} errors, {1} warnings)", errors.Count, warnings.Count);

                string scriptRoot = Path.GetFullPath(Path.Combine(ServerGlobals.BaseDirectory, "Scripts" + Path.DirectorySeparatorChar));
                Uri scriptRootUri = new Uri(scriptRoot);

                Tools.SetColor(ConsoleColor.Yellow);

                if (warnings.Count > 0)
                    Console.WriteLine("Warnings:");

                foreach (KeyValuePair<string, List<CompilerError>> kvp in warnings)
                {
                    string fileName = kvp.Key;
                    List<CompilerError> list = kvp.Value;

                    string fullPath = Path.GetFullPath(fileName);
                    string usedPath = Uri.UnescapeDataString(scriptRootUri.MakeRelativeUri(new Uri(fullPath)).OriginalString);

                    Console.WriteLine(" + {0}:", usedPath);

                    Tools.SetColor(ConsoleColor.DarkYellow);

                    foreach (CompilerError e in list)
                        Console.WriteLine("    {0}: Line {1}: {3}", e.ErrorNumber, e.Line, e.Column, e.ErrorText);

                    Tools.ResetColor();
                }

                Tools.ResetColor();

                Tools.SetColor(ConsoleColor.Red);

                if (errors.Count > 0)
                    Console.WriteLine("Errors:");

                foreach (KeyValuePair<string, List<CompilerError>> kvp in errors)
                {
                    string fileName = kvp.Key;
                    List<CompilerError> list = kvp.Value;

                    string fullPath = Path.GetFullPath(fileName);
                    string usedPath = Uri.UnescapeDataString(scriptRootUri.MakeRelativeUri(new Uri(fullPath)).OriginalString);

                    Console.WriteLine(" + {0}:", usedPath);

                    Tools.SetColor(ConsoleColor.DarkRed);

                    foreach (CompilerError e in list)
                        Console.WriteLine("    {0}: Line {1}: {3}", e.ErrorNumber, e.Line, e.Column, e.ErrorText);

                    Tools.ResetColor();
                }

                Tools.ResetColor();
            }
            else
            {
                Console.WriteLine("done (0 errors, 0 warnings)");
            }
        }
        public static void Invoke(string method)
        {
            List<MethodInfo> invoke = new List<MethodInfo>();

            for (int a = 0; a < mAssemblies.Length; ++a)
            {
                Type[] types = mAssemblies[a].GetTypes();

                for (int i = 0; i < types.Length; ++i)
                {
                    MethodInfo m = types[i].GetMethod(method, BindingFlags.Static | BindingFlags.Public);

                    if (m != null)
                        invoke.Add(m);
                }
            }

            //invoke.Sort(new CallPriorityComparer());

            for (int i = 0; i < invoke.Count; ++i)
                invoke[i].Invoke(null, null);
        }
        private static readonly Type[] mSerialTypeArray = new Type[1] { typeof(Entity) };

        private static void VerifyType(Type t)
        {
            bool isItem = t.IsSubclassOf(typeof(Item));

            if (isItem || t.IsSubclassOf(typeof(Mobile)))
            {
                if (isItem)
                {
                    //++m_ItemCount;
                    Interlocked.Increment(ref mItems);
                }
                else
                {
                    //++m_MobileCount;
                    Interlocked.Increment(ref mMobile);
                }

                StringBuilder warningSb = null;

                try
                {
                    /*
                    if( isItem && t.IsPublic && !t.IsAbstract )
                    {
                        ConstructorInfo cInfo = t.GetConstructor( Type.EmptyTypes );

                        if( cInfo == null )
                        {
                            if (warningSb == null)
                                warningSb = new StringBuilder();

                            warningSb.AppendLine("       - No zero paramater constructor");
                        }
                    }*/

                    if (t.GetConstructor(mSerialTypeArray) == null)
                    {
                        if (warningSb == null)
                            warningSb = new StringBuilder();

                        warningSb.AppendLine("       - No serialization constructor");
                    }

                    if (t.GetMethod("Serialize", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly) == null)
                    {
                        if (warningSb == null)
                            warningSb = new StringBuilder();

                        warningSb.AppendLine("       - No Serialize() method");
                    }

                    if (t.GetMethod("Deserialize", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly) == null)
                    {
                        if (warningSb == null)
                            warningSb = new StringBuilder();

                        warningSb.AppendLine("       - No Deserialize() method");
                    }

                    if (warningSb != null && warningSb.Length > 0)
                    {
                        Console.WriteLine("Warning: {0}\n{1}", t, warningSb.ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Warning: Exception in serialization verification of type {0}", t);
                }
            }
        }
        public static void VerifySerialization( Assembly a )
		{
			if( a == null )
				return;

			foreach (Type t in a.GetTypes())
			{
				VerifyType(t);
			}
		}
	}
}
