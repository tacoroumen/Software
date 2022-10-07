using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raad_een_getal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 3;
            if (textBox1.Text == "")
            {
                return;
            }
            int guessnum = int.Parse(textBox1.Text);
            if (guessnum == number)
            {
                textBox1.Clear();
                MessageBox.Show("Congratulations you guessed the correct number.\nThe correct number was " + number + ".");
            }
            if (guessnum > number)
            {
                textBox1.Clear();
                MessageBox.Show("The number you are trying to guess is lower then the number you guessed.\nThe number you guessed was " + guessnum + ".");
            }
            if (guessnum < number)
            {
                textBox1.Clear();
                MessageBox.Show("The number you are trying to guess is higher then the number you guessed.\nThe number you guessed was " + guessnum + ".");
            }
        }
    }
}
