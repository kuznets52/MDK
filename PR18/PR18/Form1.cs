using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = double.Parse(textBox1.Text);
            double B = double.Parse(textBox2.Text);
            double C = double.Parse(textBox3.Text);

            if (A != 0)
            {
                double D = B * B - 4 * A * C; 
                if (D == 0)
                {
                    label1.Text = "Уравнение имеет ровно один вещественный корень.";
                }
                else
                {
                    label1.Text = "Уравнение не имеет ровно одного вещественного корня.";
                }
            }
            else
            {
                label1.Text = "Коэффициент A не должен равняться нулю.";
            }
        }
    }
}