using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigernere1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Vigernere
        {
            #region property
            public string key { get; set; }
            public string plainText { get; set; }
            public string cipherText { get; set; }
            #endregion


            public Vigernere(string s)
            {
                key = s.ToUpper();
            }
            public Vigernere(string Key, string PlaintText,string CipherText)
            {
                key = Key;
                plainText = PlaintText;
                cipherText = CipherText;
            }
            string chuoi = "ABCDEFGHIKJLMNOPQRSTUVWXYZ";
            public int[] chuoi_mangchiso(string s)
            {
                int[] mang = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                    mang[i] = chuoi.IndexOf(s[i]);
                return mang;
            }
            public string chiso_chuoi(int[] a)
            {
                string s = "";
                for (int i = 0; i < a.Length; i++)
                    s += chuoi[a[i]];
                return s;
            }         
            public String MaHoa( )
            {
                plainText = plainText.ToUpper();
                int[] p = chuoi_mangchiso(plainText);
                int[] k = chuoi_mangchiso(key);

                int[] kq = new int[plainText.Length];
                for (int i = 0, j = 0; i < plainText.Length; i++)
                {
                    kq[i] = (p[i] + k[j]) % chuoi.Length;
                    j = ++j % k.Length;
                }
                 cipherText = chiso_chuoi(kq);
                return cipherText;
            }
            public String GiaiMa()
            {
                int[] c = chuoi_mangchiso(cipherText);
                int[] k = chuoi_mangchiso(key);

                int[] kq = new int[cipherText.Length];
                for (int i = 0, j = 0; i < cipherText.Length; i++)
                {
                    kq[i] = (c[i] - k[j]) % chuoi.Length;
                    if (kq[i] < 0)
                        kq[i] = (c[i] + (chuoi.Length - k[j])) % chuoi.Length;
                    j = ++j % k.Length;
                }
               plainText = chiso_chuoi(kq);
                return plainText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Mahoa_Click(object sender, EventArgs e)
        {
            Vigernere vg = new Vigernere(txb_Key.Text, txb_PlaintText.Text,txb_DecryptText.Text);
            txb_CipherText.Text = vg.MaHoa();
        }

        private void btn_Giaima_Click(object sender, EventArgs e)
        {
            Vigernere vg = new Vigernere(txb_Key.Text, txb_PlaintText.Text,txb_CipherText.Text);
            txb_DecryptText.Text = vg.GiaiMa();
        }
    }
}
