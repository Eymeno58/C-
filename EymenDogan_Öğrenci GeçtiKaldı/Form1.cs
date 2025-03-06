using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EymenDogan_Öğrenci_GeçtiKaldı
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puan = Int32.Parse(textBox1.Text);
            if(puan >= 50)
            {
                label1.Text = ("Geçti");
            }
            else
            {
                label1.Text = ("Kaldı");
            }
        }

    }
}
21