using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOCONVERVB14
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(textBox1.Text, out valor))
            {
                double resultado = (valor * 2.25) + 32;
                textBox2.Text = resultado.ToString("0.00");
            }
            else
            {
                textBox2.Text = "Error";
            }
        }

        private void delisleACelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void celsiusADelisleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.Show();
            this.Hide();
        }

        private void rømerACelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 y = new Form4();
            y.Show();
            this.Hide();
        }

        private void celsiusARømerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 v = new Form5();
            v.Show();
            this.Hide();
        }

        private void réaumurAFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 k = new Form6();
            k.Show();
            this.Hide();
        }

        private void fahrenheitARéaumurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 i = new Form7();
            i.Show();
            this.Hide();
        }

        private void newtonACelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 p = new Form8();
            p.Show();
            this.Hide();
        }

        private void celsiusANewtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 q = new Form9();
            q.Show();
            this.Hide();
        }

        private void rankineAKelvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 o = new Form10();
            o.Show();
            this.Hide();
        }

        private void kelvinARankineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 m = new Form11();
            m.Show();
            this.Hide();
        }
    }
}
