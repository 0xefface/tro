using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace RealmOffline
{
    public static class Tools
    {
        public static byte[] GetPacketFromFile(string fileName)
        {
            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().
                Location), fileName);
            return GetByteArrayFromFile(fileLocation);
        }
        public static bool SavePacketToFile(string fileName, byte[] packet)
        {
            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().
                Location), fileName);
            try { File.WriteAllText(fileLocation, FormatBytes(packet)); return true; }
            catch { return false; }
        }
        public static byte[] GetByteArrayFromFile(string fileLocation)
        {
            byte[] reply = new byte[] { 0x10, 0x00, 0x00, 0x00, 0x12, 0x00, 0x00, 0x00, 0x83, 0x0F, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x00 };
            string data = string.Empty;
            // If our file is bad return blank charlist
            if (!File.Exists(fileLocation))
            {
                Console.WriteLine("No File at {0}", fileLocation);
                return reply;
            }
            // Try to load the file, if we fail return blank
            try { data = File.ReadAllText(fileLocation); }
            catch (Exception ex) { Console.WriteLine(ex.Message); return reply; }
            //Console.WriteLine(data);
            // Ok is going to be alot of extra comments and crap
            // So we ignore all else, except those with 0x in front, those we convert and add
            List<byte> b = new List<byte>();
            int index = 0;
            while (data.Length != 0)
            {
                if ((index = data.IndexOf("0x")) == 0) { break; }
                // Get the byte folloiwing it
                string singleByte = string.Empty;
                try { singleByte = data.Substring(index, 4); data = data.Remove(0, index + 4); }
                catch { break; } // we are done
                singleByte = singleByte.Remove(0, 2);
                byte convert = Byte.Parse(singleByte, NumberStyles.HexNumber);
                b.Add(convert);
            }
            if (b.Count > 0) { reply = b.ToArray(); }
            return reply;
        }
        public static bool WriteByteOutputToFile(string fileName, byte[] bytes)
        {
            // Writes in the exe's dir
            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().
                Location), fileName);
            try { File.WriteAllText(fileLocation, FormatBytes(bytes)); return true; }
            catch { return false; }
        }
        public static string FormatBytes(byte[] bytes)
        {
            if (bytes == null) { return ""; }
            // Create our start
            StringBuilder result = new StringBuilder();
            result.Append("{ ");
            string convert = BitConverter.ToString(bytes);
            string[] sections = convert.Split('-');
            List<string> rebuild = new List<string>();

            for (int i = 0; i < sections.Length; i++)
            {
                if (i != sections.Length - 1)
                {
                    rebuild.Add("0x" + sections[i] + ", ");
                }
                else
                {
                    rebuild.Add("0x" + sections[i]);
                }
            }
            foreach (string s in rebuild)
            {
                result.Append(s);
            }
            result.AppendLine(" };");
            return result.ToString();
        }
        public static char ToSafeAscii(int b)
        {
            if (b >= 32 && b <= 126)
            {
                return (char)b;
            }
            return '.';
        }
        public static string NiceHexOutput(byte[] bytes, int bytesPerLine = 16)
        {
            if (bytes == null) return "<null>";
            int bytesLength = bytes.Length;

            char[] hexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - 2) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = hexChars[(i >> 28) & 0xF];
                line[1] = hexChars[(i >> 24) & 0xF];
                line[2] = hexChars[(i >> 20) & 0xF];
                line[3] = hexChars[(i >> 16) & 0xF];
                line[4] = hexChars[(i >> 12) & 0xF];
                line[5] = hexChars[(i >> 8) & 0xF];
                line[6] = hexChars[(i >> 4) & 0xF];
                line[7] = hexChars[(i >> 0) & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = hexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = hexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '·' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            return result.ToString();
        }
        public static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void ResetColor()
        {
            Console.ResetColor();
        }
        public static byte[] ReadUntil0xFF(byte[] inBuffer)
        {
            List<byte> outBuffer = new List<byte>();
            foreach (byte b in inBuffer)
            {
                if (b != 0xFF) outBuffer.Add(b);
                else break;
            }
            return outBuffer.ToArray();
        }
        public static byte[] ReadPacket41UntilFF(byte[] buffer, out int pckID, out uint roomNum)
        {
            pckID = -1;
            roomNum = 0;
            // We take the whole packet here, remove all but payload
            // 4 bytes for length
            byte[] id = new byte[4];
            Array.Copy(buffer, 4, id, 0, id.Length);
            byte[] rNum = new byte[4];
            Array.Copy(buffer, 12, rNum, 0, rNum.Length);

            roomNum = BitConverter.ToUInt32(rNum, 0);
            pckID = BitConverter.ToInt32(id, 0);
            // 16 bytes to remove
            if (buffer.Length < 16) return null;
            byte[] payload = new byte[buffer.Length - 16];
            Array.Copy(buffer, 16, payload, 0, payload.Length);
            List<byte> result = new List<byte>();
            foreach (byte b in payload)
            {
                if (b != 0xFF) result.Add(b);
                else break;
            }
            return result.ToArray();
        }
    }
}
