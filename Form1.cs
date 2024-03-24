using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DİZİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] isim = new string[5];
            isim[0]="veli";
            isim[1] = "hakan";
            isim[2] = "şemsettin";
            isim[3] = "aziz";
            isim[4] = "Necmi";

            for (int i = 0; i <= 4; i++)
            {
                listBox1.Items.Add(isim[i]);
            }
           

        }
    }
}
