using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Domain;

namespace AccountFormApp
{
    public partial class Form1 : Form
    {
        IAccountServices accService = new AccountService();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void currentlbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = lbxCurrent.SelectedItem.ToString(); //get the account name
            Decimal balance = accService.GetAccountBalance(accName); //get the balance for the account
            txtBalance.Text = balance.ToString(); //put the balance in the balance text box
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string accName = txtAccName.Text; //get the account name
            lbxCurrent.Items.Add(accName); //add the new account name to the list
            txtAccName.Text = ""; //remove the txt from the box

            accService.CreateAccount(accName, Domain.AccountType.Silver); //create the new account
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string accName = lbxCurrent.SelectedItem.ToString(); //get the selected account name
            Decimal deposit = Decimal.Parse(txtDeposit.Text); //get the deposit amount
            accService.Deposit(accName, deposit); //call the deposit method on the account
            txtDeposit.Text = ""; //remove the txt from the box

            //update the balance in the box
            Decimal balance = accService.GetAccountBalance(accName); 
            txtBalance.Text = balance.ToString();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            string accName = lbxCurrent.SelectedItem.ToString(); //get the selected account name
            Decimal withdrawal = Decimal.Parse(txtWithdrawal.Text); //get the withdrawal amount
            accService.Withdrawal(accName, withdrawal); //call the withdrawal method on the account
            txtWithdrawal.Text = ""; //remove the txt from the box

            //update the balance in the box
            Decimal balance = accService.GetAccountBalance(accName);
            txtBalance.Text = balance.ToString();
        }
    }
}
