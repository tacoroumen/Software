using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training___Array___Woordvervormer
{
    public partial class Form1 : Form
    {
        public int textlength;
        public char[] reverse = new char[100];
        public char[] LetterArray;
        public char[] upper;
        public Form1()

        {
            InitializeComponent();
        }

        public void make_array()
        {
            LetterArray = woord.Text.ToCharArray();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(woord.Text, "[^a-zA-Z]+"))
            {
                MessageBox.Show("Please enter only letters.");
                woord.Text = woord.Text.Remove(woord.Text.Length - 1);
            }
            textlength = woord.Text.Length;

    }

        public void flip_Click(object sender, EventArgs e)
        {
            make_array();
            for (int i = 0; textlength > 0; i++)
            {
                reverse[i] = LetterArray[textlength-1];
                textlength--;
            }
            string s = string.Join("", reverse);
            woord.Text = s;
        }

        public void plus_Click(object sender, EventArgs e)
        {
            make_array();
            for (int i = 0; i < textlength; i++)
            {
                LetterArray[i] = (LetterArray[i] == 'z' ? 'a' : LetterArray[i] == 'Z' ? 'A' : (char)(LetterArray[i] + 1));
            }
            string s = string.Join("", LetterArray);
            woord.Text = s;
        }

        private void oneven_Click(object sender, EventArgs e)
        {
            make_array();
            String s = "";
            for (int i = 0; i < textlength; i++)
            {
                if (i % 2 == 0)
                {
                    s += LetterArray[i];
                }
            }
            woord.Text = s;
            
        }
    }
}
