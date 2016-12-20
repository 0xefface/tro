using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decripter
{
    public partial class Form1 : Form
    {
        cryption uc;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            string stringdata = rt_ip.Text;
            stringdata = stringdata.Replace(" ", "");
            stringdata = stringdata.Replace("0x", "");
            stringdata = stringdata.Replace(",", ":");
            stringdata = stringdata.Replace("\n", "");
            string[] s = stringdata.Split(':');

            byte[] d1 = new byte[s.Length];
            int i = 0;
            foreach (string s1 in s)
            {
                d1[i++] = byte.Parse(s1, NumberStyles.HexNumber);
            }

            int k = 0;
            int t = 0;
            int lnk = 0;
            while (t < d1.Length)
            {
                lnk = BitConverter.ToInt32(d1, t);
                lnk += 4;
                byte[] bx = new byte[lnk];
                Array.Copy(d1, t + 4, bx, 0, lnk);
                t += lnk + 4;
                if (k == 0)
                {
                    uc = new cryption(bx);
                    uc.decript(bx, 0x19);
                }
                else
                {
                    uc.data = bx;
                    uc.decript();
                }
                // Get the length -4
                Int32 length = uc.data.Length - 4;
                byte[] p_len = BitConverter.GetBytes(length);
                byte[] fullPacket = new byte[p_len.Length + uc.data.Length];
                Array.Copy(p_len, fullPacket, p_len.Length);
                Array.Copy(uc.data, 0, fullPacket, 4, uc.data.Length);
                rt_op.AppendText(FormatBytes(fullPacket));//.Text += FormatBytes(fullPacket);//(uc.data) + "\n";//ByteArrayToHexString(uc.data) + "\n";
                rt_op.SelectionColor = Color.Red;
                rt_op.AppendText(NiceHexOutput(fullPacket));
                k++;
            }
        }


        private void SelectAll(RichTextBox textBox)
        {
            textBox.Select(0, textBox.Text.Length);
        }
        private void Cut(RichTextBox textBox)
        {
            textBox.Cut();
        }
        private void Copy(RichTextBox textBox)
        {
            textBox.Copy();
        }
        private void Paste(RichTextBox textBox)
        {
            textBox.Paste();
        }
        private void Undo(RichTextBox textBox)
        {
            textBox.Undo();
        }
        public static string ByteArrayToHexString(byte[] Bytes)
        {
            StringBuilder Result = new StringBuilder(Bytes.Length * 2);
            string HexAlphabet = "0123456789ABCDEF";

            foreach (byte B in Bytes)
            {
                Result.Append(HexAlphabet[(int)(B >> 4)]);
                Result.Append(HexAlphabet[(int)(B & 0xF)]);
                Result.Append(':');
            }

            return Result.ToString();
        }
        public string FormatBytes(byte[] bytes)
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
        public string NiceHexOutput(byte[] bytes, int bytesPerLine = 16)
        {
            if (bytes == null) return "<null>";
            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

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
                line[0] = HexChars[(i >> 28) & 0xF];
                line[1] = HexChars[(i >> 24) & 0xF];
                line[2] = HexChars[(i >> 20) & 0xF];
                line[3] = HexChars[(i >> 16) & 0xF];
                line[4] = HexChars[(i >> 12) & 0xF];
                line[5] = HexChars[(i >> 8) & 0xF];
                line[6] = HexChars[(i >> 4) & 0xF];
                line[7] = HexChars[(i >> 0) & 0xF];

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
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '·' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            return result.ToString();
        }

        private void inputCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Copy(this.rt_ip);
        }

        private void inputCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cut(this.rt_ip);
        }

        private void inutPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Paste(this.rt_ip);
        }

        private void inputSelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SelectAll(this.rt_ip);
        }

        private void outputCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Copy(this.rt_op);
        }

        private void outputCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cut(this.rt_op);
        }

        private void outputPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Paste(this.rt_op);
        }

        private void outputSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SelectAll(this.rt_op);
        }

        private void inputUndoLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Undo(this.rt_ip);
        }

        private void undoLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Undo(this.rt_op);
        }

    }
}
