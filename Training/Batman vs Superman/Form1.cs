using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batman_vs_Superman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RandomNumb(int min, int max)
        {
            var randomnum = new Random();
            return randomnum.Next(min, max);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int remaining = 20;
            kracht_superman.Text = remaining.ToString();
            kracht_batman.Text = remaining.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (laser.Checked == true)
            {
                int batman_remaining = int.Parse(kracht_batman.Text) - RandomNumb(1, 8);
                kracht_batman.Text = batman_remaining.ToString();
            }
            if (Superkracht.Checked == true)
            {
                int batman_remaining = int.Parse(kracht_batman.Text) - RandomNumb(5, 7);
                kracht_batman.Text = batman_remaining.ToString();
            }
            if (int.Parse(kracht_batman.Text) <= 0)
            {
                kracht_batman.Text = 0.ToString();
                MessageBox.Show("Superman has won the fight.");
                restart.Visible = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (batarang.Checked == true)
            {
                int superman_remaining = int.Parse(kracht_superman.Text) - RandomNumb(1, 8);
                kracht_superman.Text = superman_remaining.ToString();
            }
            if (Kungfu.Checked == true)
            {
                int superman_remaining = int.Parse(kracht_superman.Text) - RandomNumb(5, 7);
                kracht_superman.Text = superman_remaining.ToString();
            }
            if (int.Parse(kracht_superman.Text) <= 0)
            {
                kracht_superman.Text = 0.ToString();
                MessageBox.Show("batman has won the fight.");
                restart.Visible = true;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void kracht_superman_Click(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            int remaining = 20;
            kracht_superman.Text = remaining.ToString();
            kracht_batman.Text = remaining.ToString();
            restart.Visible = false;
        }
    }
}
