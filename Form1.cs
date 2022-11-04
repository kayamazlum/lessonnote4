using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // [1] iki boyutlu dizinin elemanlarının toplamı ve ortalamasını verir
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] dizi = new int[4,3]{ { 10,20,30},{ 30,20,10},{ 20, 10, 30},{ 30, 10, 20} };
            int row = 4, col = 3, toplam = 0, avg ;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    toplam = toplam + dizi[i, j];
                }
            }
            label3.Text = toplam.ToString();
            label4.Text = (toplam / dizi.Length).ToString();
        }

        // [2] iki boyutlu dizinin en büyük elemanını bulur
        private void button2_Click(object sender, EventArgs e)
        {
            int[,] dizi = new int[4,2] { { 10, 35}, { 30, 20}, { 20, 10 }, { 30, 10 } };
            int row = 4, col = 2 , toplam = 0, avg ;
            int x = dizi[0, 0];
            for(int i = 0; i < row; i++)
            {
                for( int j = 0; j < col; j++)
                {
                    if(dizi[i, j] > x)
                    {
                        x = dizi[i, j];
                    } 
                }
            }
            MessageBox.Show("Max değer : " + x);
        }

        // [3] iki boyutlu diziye veriler(isimler, notlar) ekler 
        string[] isimler = new string[3];
        int[,] notlar = new int[3, 3];
        int index = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            notlar[index, 0] = Convert.ToInt16(textBox2.Text);
            notlar[index, 1] = Convert.ToInt16(textBox3.Text);
            notlar[index, 2] = Convert.ToInt16(textBox4.Text);
            index++;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        // [4] iki boyutlu dizidekii verileri düzgün şekilde listeler
        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                int toplam = 0;
                for(int j = 0; j < 3; j++)
                {
                    toplam = toplam + notlar[i, j];
                }
                listBox1.Items.Add(isimler[i] +" = "+(toplam/3));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cift = 0, tek = 0;
            Random reader = new Random();
            int[] dizi = new int[40];
            for(int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = reader.Next(0,100);
                listBox2.Items.Add(dizi[i]);
                
                if(dizi[i] % 2 == 0)
                {
                    cift++;
                }
                tek = 40 - cift;
            }
            label11.Text = tek.ToString();
            label12.Text = cift.ToString();
        }
    }
}
