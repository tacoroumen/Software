using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Blackjack__light_
{
    public partial class Form1 : Form
    {
        public int[] cardArray = { 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11 };
        public Random r = new Random();
        public int TotalCardValPlay;
        public int TotalCardValBank;
        public Form1()
        {
            InitializeComponent();
        }

        public int CardVal(int totalcardval)
        {
            int rnd = r.Next(0, 52);
            int randomCardValue = cardArray[rnd];
            while (randomCardValue == 0)
            {   
                rnd = r.Next(0, 52);
                randomCardValue = cardArray[rnd];
            }
            if (randomCardValue == 11)
            {
                if (randomCardValue + totalcardval > 21)
                {
                    randomCardValue = 1;
                }
            }
            cardArray[rnd] = 0;
            int finalCardValue = randomCardValue;
            return finalCardValue;
        }

        private void CardVallue_Click(object sender, EventArgs e)
        {

        }

        private void Deal_Click(object sender, EventArgs e)
        {
            int randomCardValue = CardVal(TotalCardValPlay);
            TotalCardValPlay += randomCardValue;

            randomCardValue = CardVal(TotalCardValBank);
            TotalCardValBank += randomCardValue;

            CardVallue.Text = Convert.ToString(TotalCardValPlay);
            Deal.Visible = false;
            Stand.Visible = true;
            Hit.Visible = true;
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            Stand.Visible = false;
            Hit.Visible = false;
            while (TotalCardValBank < 17)
            {
                int randomCardValue = CardVal(TotalCardValBank);
                TotalCardValBank += randomCardValue;
            }
            if (TotalCardValBank > 21)
            {
                MessageBox.Show("The player has won because the bank went bust with a total card vallue of " + TotalCardValBank);
            }
            else
            {
                if (TotalCardValBank > TotalCardValPlay)
                {
                    MessageBox.Show("The bank has won with a card vallue of " + TotalCardValBank + " against the player's card vallue of " + TotalCardValPlay);
                }
                if (TotalCardValBank < TotalCardValPlay)
                {
                    MessageBox.Show("The player has won with a card vallue of " + TotalCardValPlay + " against the bank's card vallue of " + TotalCardValBank);
                }
                if (TotalCardValBank == TotalCardValPlay)
                {
                    MessageBox.Show("Neither the bank nor player has won because they both have the same card vallue. The bank's card vallue was " + TotalCardValBank + ". The player's card vallue was " + TotalCardValBank  + ".");
                }
            }
            Stand.Visible = false;
            Hit.Visible = false;
            Restart.Visible = true;
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            int randomCardValue = CardVal(TotalCardValPlay);
            TotalCardValPlay += randomCardValue;

            CardVallue.Text = Convert.ToString(TotalCardValPlay);
            if (TotalCardValPlay > 21)
            {
                MessageBox.Show("You went bust with a total card vallue of " + TotalCardValPlay);
                Stand.Visible = false;
                Hit.Visible = false;
                Restart.Visible = true;

            }
            if (TotalCardValPlay == 21)
            {
                MessageBox.Show("Blackjack! You won!!");
                Stand.Visible = false;
                Hit.Visible = false;
                Restart.Visible = true;
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }
    }
}
