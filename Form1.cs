using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Form1 : Form
    {
        int so_a, so_b, c;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            so_a = Int32.Parse(textBox1.Text.ToString());
            so_b = Int32.Parse(textBox2.Text.ToString());
            c = so_a + so_b;
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            so_a = Int32.Parse(textBox1.Text.ToString());
            so_b = Int32.Parse(textBox2.Text.ToString());
            c = so_a - so_b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            so_a = Int32.Parse(textBox1.Text.ToString());
            so_b = Int32.Parse(textBox2.Text.ToString());
            c = so_a * so_b;
            textBox3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            so_a = Int32.Parse(textBox1.Text.ToString());
            so_b = Int32.Parse(textBox2.Text.ToString());
            c = so_a / so_b;
            textBox3.Text = c.ToString();
        }
        
    }
}
