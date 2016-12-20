using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using RealmOffline;
using System.CodeDom.Compiler;
using System.Security.Cryptography;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using RealmOffline.Core;

namespace RealmOfflineWorldServer.Core.Scripting
{
    public static class ScriptCompiler
    {
        private static Assembly[] m_Assemblies;

        public static Assembly[] Assemblies
        {
            get
            {
                return m_Assemblies;
            }
            set
            {
                m_Assemblies = value;
            }
        }
        private static List<string> m_AdditionalReferences = new List<string>();

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

            list.Add(ServerGlobals.BaseDirectory);

            list.AddRange(m_AdditionalReferences);

            return list.ToArray();
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

			AppendCompilerOption( ref sb, "/d:Framework_4_0" );

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
        public static void EnsureDirectory(string dir)
        {
            string path = Path.Combine(ServerGlobals.BaseDirectory, dir);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
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

        public static string GetUnusedPath(string name)
        {
            string path = Path.Combine(ServerGlobals.BaseDirectory, String.Format("Scripts/Output/{0}.dll", name));

            for (int i = 2; File.Exists(path) && i <= 1000; ++i)
                path = Path.Combine(ServerGlobals.BaseDirectory, String.Format("Scripts/Output/{0}.{1}.dll", name, i));

            return path;
        }

        public static void DeleteFiles(string mask)
        {
            try
            {
                string[] files = Directory.GetFiles(Path.Combine(ServerGlobals.BaseDirectory, "Scripts/Output"), mask);

                foreach (string file in files)
                {
                    try { File.Delete(file); }
                    catch { }
                }
            }
            catch
            {
            }
        }
        private static byte[] GetHashCode(string compiledFile, string[] scriptFiles, bool debug)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter bin = new BinaryWriter(ms))
                {
                    FileInfo fileInfo = new FileInfo(compiledFile);

                    bin.Write(fileInfo.LastWriteTimeUtc.Ticks);

                    foreach (string scriptFile in scriptFiles)
                    {
                        fileInfo = new FileInfo(scriptFile);

                        bin.Write(fileInfo.LastWriteTimeUtc.Ticks);
                    }

                    bin.Write(debug);
                    //bin.Write(Core.Version.ToString());

                    ms.Position = 0;

                    using (SHA1 sha1 = SHA1.Create())
                    {
                        return sha1.ComputeHash(ms);
                    }
                }
            }
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
        public static bool CompileCSScripts(out Assembly assembly)
        {
            return CompileCSScripts(false, true, out assembly);
        }

        public static bool CompileCSScripts(bool debug, out Assembly assembly)
        {
            return CompileCSScripts(debug, true, out assembly);
        }

        public static bool CompileCSScripts(bool debug, bool cache, out Assembly assembly)
        {
            
            string[] files = GetScripts("*.cs");
            Console.Write("Scripts: Compiling {0} C# scripts...", files.Length);
            if (files.Length == 0)
            {
                Console.WriteLine("no files found.");
                assembly = null;
                return true;
            }

            if (File.Exists("Scripts/Output/Scripts.CS.dll"))
            {
                if (cache && File.Exists("Scripts/Output/Scripts.CS.hash"))
                {
                    try
                    {
                        byte[] hashCode = GetHashCode("Scripts/Output/Scripts.CS.dll", files, debug);

                        using (FileStream fs = new FileStream("Scripts/Output/Scripts.CS.hash", FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            using (BinaryReader bin = new BinaryReader(fs))
                            {
                                byte[] bytes = bin.ReadBytes(hashCode.Length);

                                if (bytes.Length == hashCode.Length)
                                {
                                    bool valid = true;

                                    for (int i = 0; i < bytes.Length; ++i)
                                    {
                                        if (bytes[i] != hashCode[i])
                                        {
                                            valid = false;
                                            break;
                                        }
                                    }

                                    if (valid)
                                    {
                                        assembly = Assembly.LoadFrom("Scripts/Output/Scripts.CS.dll");

                                        if (!m_AdditionalReferences.Contains(assembly.Location))
                                        {
                                            m_AdditionalReferences.Add(assembly.Location);
                                        }

                                        Console.WriteLine("done (cached)");

                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }

            DeleteFiles("Scripts.CS*.dll");

            using (CSharpCodeProvider provider = new CSharpCodeProvider())
            {
                string path = GetUnusedPath("Scripts.CS");

                CompilerParameters parms = new CompilerParameters(GetReferenceAssemblies(), path, debug);

                string options = GetCompilerOptions(debug);

                if (options != null)
                    parms.CompilerOptions = options;

               // if (Core.HaltOnWarning)
                  //  parms.WarningLevel = 4;

#if !MONO
                CompilerResults results = provider.CompileAssemblyFromFile(parms, files);
#else
				parms.CompilerOptions = String.Format( "{0} /nowarn:169,219,414 /recurse:Scripts/*.cs", parms.CompilerOptions );
				CompilerResults results = provider.CompileAssemblyFromFile( parms, "" );
#endif
                m_AdditionalReferences.Add(path);

                Display(results);

#if !MONO
                if (results.Errors.Count > 0)
                {
                    assembly = null;
                    return false;
                }
#else
				if( results.Errors.Count > 0 ) {
					foreach( CompilerError err in results.Errors ) {
						if ( !err.IsWarning ) {
							assembly = null;
							return false;
						}
					}
				}
#endif


                if (cache && Path.GetFileName(path) == "Scripts.CS.dll")
                {
                    try
                    {
                        byte[] hashCode = GetHashCode(path, files, debug);

                        using (FileStream fs = new FileStream("Scripts/Output/Scripts.CS.hash", FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            using (BinaryWriter bin = new BinaryWriter(fs))
                            {
                                bin.Write(hashCode, 0, hashCode.Length);
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                assembly = results.CompiledAssembly;
                return true;
            }
        }

        public static bool CompileVBScripts(out Assembly assembly)
        {
            return CompileVBScripts(false, out assembly);
        }

        public static bool CompileVBScripts(bool debug, out Assembly assembly)
        {
            return CompileVBScripts(debug, true, out assembly);
        }

        public static bool CompileVBScripts(bool debug, bool cache, out Assembly assembly)
        {
            Console.Write("Scripts: Compiling VB.NET scripts...");
            string[] files = GetScripts("*.vb");

            if (files.Length == 0)
            {
                Console.WriteLine("no files found.");
                assembly = null;
                return true;
            }

            if (File.Exists("Scripts/Output/Scripts.VB.dll"))
            {
                if (cache && File.Exists("Scripts/Output/Scripts.VB.hash"))
                {
                    byte[] hashCode = GetHashCode("Scripts/Output/Scripts.VB.dll", files, debug);

                    try
                    {
                        using (FileStream fs = new FileStream("Scripts/Output/Scripts.VB.hash", FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            using (BinaryReader bin = new BinaryReader(fs))
                            {
                                byte[] bytes = bin.ReadBytes(hashCode.Length);

                                if (bytes.Length == hashCode.Length)
                                {
                                    bool valid = true;

                                    for (int i = 0; i < bytes.Length; ++i)
                                    {
                                        if (bytes[i] != hashCode[i])
                                        {
                                            valid = false;
                                            break;
                                        }
                                    }

                                    if (valid)
                                    {
                                        assembly = Assembly.LoadFrom("Scripts/Output/Scripts.VB.dll");

                                        if (!m_AdditionalReferences.Contains(assembly.Location))
                                        {
                                            m_AdditionalReferences.Add(assembly.Location);
                                        }

                                        Console.WriteLine("done (cached)");

                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }

            DeleteFiles("Scripts.VB*.dll");

            using (VBCodeProvider provider = new VBCodeProvider())
            {
                string path = GetUnusedPath("Scripts.VB");

                CompilerParameters parms = new CompilerParameters(GetReferenceAssemblies(), path, debug);

                string options = GetCompilerOptions(debug);

                if (options != null)
                    parms.CompilerOptions = options;

                //if (Core.HaltOnWarning)
                   // parms.WarningLevel = 4;

                CompilerResults results = provider.CompileAssemblyFromFile(parms, files);
                m_AdditionalReferences.Add(path);

                Display(results);

                if (results.Errors.Count > 0)
                {
                    assembly = null;
                    return false;
                }

                if (cache && Path.GetFileName(path) == "Scripts.VB.dll")
                {
                    try
                    {
                        byte[] hashCode = GetHashCode(path, files, debug);

                        using (FileStream fs = new FileStream("Scripts/Output/Scripts.VB.hash", FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            using (BinaryWriter bin = new BinaryWriter(fs))
                            {
                                bin.Write(hashCode, 0, hashCode.Length);
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                assembly = results.CompiledAssembly;
                return true;
            }
        }
        private delegate CompilerResults Compiler(bool debug);

        public static bool Compile()
        {
            return Compile(false);
        }

        public static bool Compile(bool debug)
        {
            return Compile(debug, true);
        }

        public static bool Compile(bool debug, bool cache)
        {
            EnsureDirectory("Scripts/");
            EnsureDirectory("Scripts/Output/");

            if (m_AdditionalReferences.Count > 0)
                m_AdditionalReferences.Clear();

            List<Assembly> assemblies = new List<Assembly>();

            Assembly assembly;

            if (CompileCSScripts(debug, cache, out assembly))
            {
                if (assembly != null)
                {
                    assemblies.Add(assembly);
                }
            }
            else
            {
                return false;
            }

            if (ServerGlobals.UseVBScripts)
            {
                if (CompileVBScripts(debug, cache, out assembly))
                {
                    if (assembly != null)
                    {
                        assemblies.Add(assembly);
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Scripts: Skipping VB.NET Scripts...done (use -vb to enable)");
            }

            if (assemblies.Count == 0)
            {
                return false;
            }

            m_Assemblies = assemblies.ToArray();

            Console.Write("Scripts: Verifying...");

            Stopwatch watch = Stopwatch.StartNew();

           // Core.VerifySerialization();

            watch.Stop();

           // Console.WriteLine("done ({0} items, {1} mobiles) ({2:F2} seconds)", Core.ScriptItems, Core.ScriptMobiles, watch.Elapsed.TotalSeconds);

            return true;
        }
        //private static readonly Type[] m_SerialTypeArray = new Type[1] { typeof(Serial) };

        private static void VerifyType(Type t)
        {
            bool isItem = t.IsSubclassOf(typeof(Item));

            if (isItem || t.IsSubclassOf(typeof(Mobile)))
            {
                if (isItem)
                {
                    //++m_ItemCount;
                   // Interlocked.Increment(ref m_ItemCount);
                }
                else
                {
                    //++m_MobileCount;
                   // Interlocked.Increment(ref m_MobileCount);
                }

                //StringBuilder warningSb = null;
                /*
                try
                {
                    
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
                    /*
                    if (t.GetConstructor(m_SerialTypeArray) == null)
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
                     */
            }
                     
        }
        public static Type FindTypeByName(string name, bool ignoreCase = true)
        {
            if (ignoreCase) { name = name.ToLower(); }
            return Type.GetType(name);
        }
        private static void VerifySerialization(Assembly a)
        {
            if (a == null)
                return;


			Parallel.ForEach(a.GetTypes(), t => 
				{
					VerifyType(t);
				});
        }
    }
}
