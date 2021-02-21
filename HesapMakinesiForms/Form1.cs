using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiForms
{
    public partial class Form1 : Form
    {
        double sayi1;
        string islem;
        double sayi2;
        double sonuc;
        double sayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {

            rtbEkran1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "2";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "0";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += "9";
        }
        private void bTemizle_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text = "";
            tbEkran.Text = "";
        }

        private void bArti_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(rtbEkran1.Text);
            islem = "+";
            rtbEkran1.Text = "";
            tbEkran.Text = sayi1 + islem;
        }

        private void bOndalikYapma_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text += ",";
        }

        private void bEksi_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(rtbEkran1.Text);
            islem = "-";
            rtbEkran1.Text = "";
            tbEkran.Text = sayi1 + islem;
        }

        private void bCarpi_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(rtbEkran1.Text);
            islem = "*";
            rtbEkran1.Text = "";
            tbEkran.Text = sayi1 + islem;
        }

        private void bBolme_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(rtbEkran1.Text);
            islem = "/";
            rtbEkran1.Text = "";
            tbEkran.Text = sayi1 + islem;
        }

        private void besittir_Click(object sender, EventArgs e)
        {

            sayi2 = Convert.ToDouble(rtbEkran1.Text);
            string sonucText = "";

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                if (sayi2 == 0)
                {
                    //sonuc = 0;
                    sonucText = "????????????";
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
            }

            if (string.IsNullOrEmpty(sonucText))
                sonucText = sonuc.ToString();
            tbEkran.Text = sayi1.ToString() + islem + sayi2.ToString() + "=";
            rtbEkran1.Text = sonucText;

        }

        private void bisaretDegistirme_Click(object sender, EventArgs e)
        {
            if (rtbEkran1.Text != "")
            {
                sayi = Convert.ToDouble(rtbEkran1.Text);
                if (sayi.ToString() == rtbEkran1.Text)
                {
                    rtbEkran1.Text = (sayi * (-1)).ToString();
                }
                
            }            
        }
        private void bCE_Click(object sender, EventArgs e)
        {
            rtbEkran1.Text = "";
        }

        private void bKare_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(rtbEkran1.Text);
            rtbEkran1.Text = Math.Pow(sayi, 2).ToString();
            tbEkran.Text = "sqr" + "("+sayi+")";
        }

        private void bKareKök_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(rtbEkran1.Text);
            rtbEkran1.Text = Math.Sqrt(sayi).ToString();
            tbEkran.Text = "√" + "(" + sayi + ")";
        }
    }
}
