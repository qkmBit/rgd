using System;
using rgd.main;
using System.Windows.Forms;

namespace rgd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            textBox2.Text = main.Translate(textBox1.Text);

        }
    }
}
