using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuraÇekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            ad = textBox1.Text;
            listBox1.Items.Add(ad);
            textBox1.Clear();
            label3.Text=rnd.Next(0, 10).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label2.Text = "";
            int list_sayi = listBox1.Items.Count;
            int[] isimler = new int[list_sayi];
      
            int i = 0;
            while (i < 3)
            {
                int secim = rnd.Next(0, list_sayi);
                if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label2.Text += listBox1.Items[secim-1] + "\n";
                    i++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
