using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decripter
{
    
        class cryption
        {
            public int muliplier = 0;
            int m2 = 0x180ef;
            int crc;
            public byte[] data;
            int[] worddata;
            private bool skip = true;
            public cryption(byte[] ip)
            {
                data = ip;
            }
            public void decript(byte[] dt)
            {
                data = dt;
                decript();
            }
            public byte[] decript()
            {
                int leng = data.Length;
                int pos = 0;
                leng = leng / 4;

                Convertbytetoword(leng);
                crc = worddata[0];
                if (!skip)
                {
                    muliplier *= m2;
                    muliplier++;
                }
                skip = false;
                worddata[pos] ^= muliplier;
                muliplier *= m2;
                muliplier++;

                worddata[pos + 1] ^= muliplier;
                crc ^= worddata[pos + 1];
                muliplier *= m2;
                muliplier++;
                worddata[pos + 2] ^= muliplier;
                crc ^= worddata[pos + 2];
                muliplier *= m2;
                muliplier++;
                worddata[pos + 3] ^= muliplier;
                crc ^= worddata[pos + 3];
                if (leng > 4)
                {
                    pos += 4;
                    leng -= 5;
                }

                for (; leng > 0; pos++, leng--)
                {
                    crc ^= worddata[pos];
                }
                wordtobyte();
                return data;
            }
            public void Convertbytetoword(int l)
            {
                worddata = new int[l];
                for (int i = 0; i < l; i++)
                {
                    worddata[i] = BitConverter.ToInt32(data, i * 4);
                }
            }
            public void decript(byte[] b, int id)
            {
                data = b;
                Int32 ipdat = BitConverter.ToInt32(data, 0);
                muliplier = ipdat ^ id;
                decript();

            }
            public void wordtobyte()
            {

                for (int i = 0; i < worddata.Length; i++)
                    Array.Copy(BitConverter.GetBytes(worddata[i]), 0, data, i * 4, 4);
            }
        }
    
}
