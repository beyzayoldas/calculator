using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
       private char _islem; //isimlendirme kuralı
       bool _ekranTemizleme; //ekranı temizlemek için
        int _ilkSayi; //işleme girecek ilk sayı
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme == true)
            {
                label1.Text = "";
                _ekranTemizleme = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";
        }

        private void buttontoplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizleme = true;
            _ilkSayi=Convert.ToInt32(label1.Text);
        }

        private void buttoneşittir_Click(object sender, EventArgs e)
        {
           int ikinciSayi=Convert.ToInt32(label1.Text) ;
           int sonuc;
            
            switch (_islem) 
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0; //sonuç hata vermesin diye
                    break;   
                
            }      

            label1.Text=Convert.ToString(sonuc);
        }

        private void buttoncıkarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizleme = true;
            _ilkSayi = Convert.ToInt32(label1.Text);
        }

        private void buttoncarpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizleme = true;
            _ilkSayi = Convert.ToInt32(label1.Text);
        }

        private void buttonbolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizleme = true;
            _ilkSayi = Convert.ToInt32(label1.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            label1.Text = "0"; //ekran temizleme düğmesi 0 dedik.
        }
    }
}
