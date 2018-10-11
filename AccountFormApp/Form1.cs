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
            string accName = lbxCurrent.SelectedItem.ToString();
            Decimal balance = accService.GetAccountBalance(accName);
            txtBalance.Text = balance.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string accName = txtAccName.Text;
            lbxCurrent.Items.Add(accName);
            txtAccName.Text = "";

            accService.CreateAccount(accName, Domain.AccountType.Silver);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string accName = lbxCurrent.SelectedItem.ToString();
            Decimal deposit = Decimal.Parse(txtDeposit.Text);
            accService.Deposit(accName, deposit);
            txtDeposit.Text = "";

            Decimal balance = accService.GetAccountBalance(accName);
            txtBalance.Text = balance.ToString();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            string accName = lbxCurrent.SelectedItem.ToString();
            Decimal withdrawal = Decimal.Parse(txtWithdrawal.Text);
            accService.Withdrawal(accName, withdrawal);
            txtWithdrawal.Text = "";

            Decimal balance = accService.GetAccountBalance(accName);
            txtBalance.Text = balance.ToString();
        }
    }
}
