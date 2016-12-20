using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RealmOffline.Core
{
    public static class Extentions
    {
        #region String Extentions
        /// <summary>
        /// Returns a byte array that contains 2 bytes (ushort)
        /// that holds the length of the following string data.
        /// </summary>
        /// <param name="data">the string to encode</param>
        /// <returns>the data in a length prefixed byte array</returns>
        public static byte[] ToLengthPrefixedString(this string data)
        {
            List<byte> buffer = new List<byte>();
            // encode the string
            byte[] encoded = Encoding.ASCII.GetBytes(data);
            buffer.AddRange(BitConverter.GetBytes((ushort)encoded.Length));
            buffer.AddRange(encoded);
            return buffer.ToArray();
        }
        /// <summary>
        /// String extention to clean unwanted 0 bytes
        /// that sometimes get carried over when encoding 
        /// a byte array with padding to ascii.
        /// </summary>
        /// <param name="encoded"></param>
        /// <returns>a string with no 0's at the end.</returns>
        public static string CleanEncodedString(this string encoded)
        {
            return CleanByteString(encoded);
        }
        private static string CleanByteString(string text)
        {
            byte[] cmdText = Encoding.ASCII.GetBytes(text);

            try
            {
                while (cmdText[cmdText.Length - 1] == 0)
                {
                    byte[] newArray = new byte[cmdText.Length - 1];
                    Array.Copy(cmdText, 0, newArray, 0, newArray.Length);
                    cmdText = newArray;
                }
            }
            catch { }
            return Encoding.ASCII.GetString(cmdText);
        }

        #endregion
        /// <summary>
        /// Extracts the payload from a gamepacket
        /// for Sierra's The Realm Online 3.0 Game.
        /// </summary>
        /// <param name="packet">the unencrypted packet.</param>
        /// <param name="packetID">the packet id</param>
        /// <returns>the payload only.</returns>
        public static byte[] GetPayload(this byte[] packet, out int packetID)
        {
            // This is for realm packets, first 4 bytes are the length
            // of the data packet, + the packet ID - crc
            packetID = BitConverter.ToInt32(packet, 4);
            byte[] buffer = new byte[packet.Length - 12];
            Array.Copy(packet, 8, buffer, 0, buffer.Length);
            return buffer;
        }
        public static byte[] ToByteArray(this Stream stream)
        {
            using (stream)
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    stream.CopyTo(memStream);
                    return memStream.ToArray();
                }
            }
        }
        public static byte[] ToRealmPacket(this byte[] packet)
        {
            // when we get this stream, we have 4 bytes of packet id
            // then data until end
            List<byte> data = new List<byte>();
            data.AddRange(BitConverter.GetBytes(packet.Length));
            data.AddRange(packet);
            data.AddRange(new byte[4]);
            return data.ToArray();
        }
        public static byte[] ToRealmPacket(this Stream stream)
        {
            // when we get this stream, we have 4 bytes of packet id
            // then data until end
            byte[] packet = stream.ToByteArray();
            List<byte> data = new List<byte>();
            data.AddRange(BitConverter.GetBytes(packet.Length));
            data.AddRange(packet);
            data.AddRange(new byte[4]);
            return data.ToArray();
        }
        public static byte[] ToRealmPacket(this List<byte> list)
        {
            // when we get this stream, we have 4 bytes of packet id
            // then data until end
            byte[] packet = list.ToArray();
            List<byte> data = new List<byte>();
            data.AddRange(BitConverter.GetBytes(packet.Length));
            data.AddRange(packet);
            data.AddRange(new byte[4]);
            return data.ToArray();
        }
        public static bool HasXBytesLeft(this BinaryReader reader, int xBytes)
        {
            // get current Position
            long currentPosition = 0;
            long totalLength = 0;
            try { currentPosition = reader.BaseStream.Position; }
            catch { return false; }
            try { totalLength = reader.BaseStream.Length; }
            catch { return false; }
            return currentPosition + xBytes <= totalLength;
        }
    }
}
