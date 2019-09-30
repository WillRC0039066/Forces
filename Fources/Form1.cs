using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fources
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double force = double.Parse(textBox1.Text);
            double angle = double.Parse(textBox1.Text);


            double Fx = force * cos(angle);
            label2.Text = "Fx =" + Fx;

            double Fy = force * sin(angle);
            label1.Text = "Fy =" + Fy;
        }
               
    }
}
