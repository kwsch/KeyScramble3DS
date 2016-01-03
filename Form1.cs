using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyScramble3DS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Scramble_Click(object sender, EventArgs e)
        {
            string KeyX = TB_KeyX.Text.Select(char.ToUpper).Where("0123456789ABCDEF".Contains).Aggregate("", (str, c) => str + c);
            string KeyY = TB_KeyX.Text.Select(char.ToUpper).Where("0123456789ABCDEF".Contains).Aggregate("", (str, c) => str + c);
            if (KeyX.Length != 0x20)
            { MessageBox.Show("KeyX Length Invalid"); return; }
            if (KeyY.Length != 0x20)
            { MessageBox.Show("KeyY Length Invalid"); return; }

            TB_KeyN.Text = CTR.keyScramble3DS(TB_KeyX.Text, TB_KeyY.Text);
        }
    }

    public class CTR
    {
        internal static readonly byte[] C = { 0x8A, 0x76, 0x52, 0x5D, 0xDC, 0x91, 0x45, 0x02, 0x08, 0x04, 0xFE, 0xC5, 0xAA, 0xE9, 0xF9, 0x1F };
        internal static byte[] keyScramble3DS(byte[] KeyX, byte[] KeyY)
        {
            if (KeyX.Length != 0x10 || KeyY.Length != 0x10 || C.Length != 0x10)
                return new byte[0x10];

            byte[] nKey;
            nKey = ROL(KeyX, 2);
            nKey = XOR(nKey, KeyY);
            nKey = ADD(nKey, C);
            nKey = ROL(nKey, 87);
            return nKey;
        }
        internal static byte[] XOR(byte[] a, byte[] b)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] ^= b[i];
            return a;
        }
        internal static byte[] ADD(byte[] a, byte[] b)
        {
            int carry = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int sum = a[i] + b[i] + carry;
                a[i] = (byte)(sum & 0xFF);
                carry = sum >> 8;
            }
            return a;
        }
        internal static byte[] ROL(byte[] a, int n)
        {
            // decompose to bits
            int[] ba = new int[a.Length * 8];
            for (int i = 0; i < ba.Length; i++)
                ba[i] = ((a[i / 8] >> (i % 8)) & 1);
            // apply rotation
            int[] rol_ba = new int[ba.Length];
            Array.Copy(ba, ba.Length - n, rol_ba, 0, n);
            Array.Copy(ba, 0, rol_ba, n, ba.Length - n);
            // reassemble to bytes
            byte[] bytes = new byte[rol_ba.Length / 8];
            for (int i = 0; i < rol_ba.Length; i++)
                bytes[i/8] |= (byte)(rol_ba[i] << i%8);
            return bytes;
        }

        // String Input
        internal static string keyScramble3DS(string KeyX, string KeyY)
        {
            return getHexString(
                keyScramble3DS(
                getByteArray(KeyX), // KeyX
                getByteArray(KeyY) // KeyY
                ));
        }
        internal static string getHexString(byte[] data)
        {
            return BitConverter.ToString(data.Reverse().ToArray()).Replace("-", "");
        }
        internal static byte[] getByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .Reverse().ToArray();
        }
    }
}
