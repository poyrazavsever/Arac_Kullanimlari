using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Baran";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Emel";
            label5.Text = "Öztürk";
            label8.Text = "Öğretmen";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yazılım Mühendisliği";
            label9.Text = textBox1.Text;
        }
    }
}
