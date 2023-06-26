using System;
using System.Windows.Forms;

namespace Cumleyi_Terse_Cevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;
        string a, b = "";

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            for (i = a.Length - 1; i >= 0; i--)
                b += a.Substring(i, 1);
            textBox2.Text = b;
        }
    }
}
