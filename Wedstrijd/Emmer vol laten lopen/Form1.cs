using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Emmer_vol_laten_lopen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            float emmer_size_cl = float.Parse(emmer_size.Text) * 1000;
            int emmersize_cl = (int)emmer_size_cl;
            progressBar1.Maximum = emmersize_cl;
            for (int total_water = 0;  emmersize_cl >= total_water; )
            {
                total_water += int.Parse(beker_size.Text);
                Thread.Sleep(100);
                Application.DoEvents();
                if (total_water > emmersize_cl)
                {
                    total_water = emmersize_cl;
                }
                progressBar1.Value=total_water;
            }
        }

        private void emmer_size_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(emmer_size.Text, "[^0-9],."))
            {
                MessageBox.Show("Please enter only numbers and dots.");
                emmer_size.Text = emmer_size.Text.Remove(emmer_size.Text.Length - 1);
            }
        }

        private void beker_size_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(beker_size.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                beker_size.Text = beker_size.Text.Remove(beker_size.Text.Length - 1);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
