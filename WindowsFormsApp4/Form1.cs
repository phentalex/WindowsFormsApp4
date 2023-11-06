using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double r = Convert.ToDouble(textBox3.Text);
            if (x >= 0 && Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2) ||
                x <= 0 && Math.Abs(x) <= r && y >= -r && y <= r && y <= x || y >= -x)
            {
                MessageBox.Show("Точка попадает в закрашенную область");
            } else
            {
                MessageBox.Show("Точка попадает мимо закрашенной области");
            }
        }
    }
}