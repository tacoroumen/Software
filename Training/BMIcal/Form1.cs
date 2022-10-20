using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Tortar : Form
    {
        public Tortar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Weight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Weight.Text = Weight.Text.Remove(Weight.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float BMI;
            float height_meter;
            height_meter = float.Parse(height.Text) / 100;
            BMI = float.Parse(Weight.Text) / ((height_meter) * (height_meter));
            MessageBox.Show("Your BMI is " + BMI.ToString("0.0") + ".");
            

        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Weight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                height.Text = height.Text.Remove(height.Text.Length - 1);
            }
        }
    }
}
