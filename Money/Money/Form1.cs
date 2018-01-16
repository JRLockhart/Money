using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            JoeLabel.Text = joe.Name + " has $" + joe.Cash;
            BobLabel.Text = bob.Name + " has $" + bob.Cash;
            BankLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 50, Name = "Joe" };

            bob = new Guy() { Cash = 100, Name = "Bob" };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void JoeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash > 0)
            {
                joe.Cash -= 10;
                bob.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe is out of money!!");
            }
        }

        private void BobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash > 0)
            {
                bob.Cash -= 5;
                joe.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob is out of money!!");
            }
        }
    }
}
