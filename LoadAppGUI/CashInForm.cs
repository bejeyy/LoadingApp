using Load_BusinessDataLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadAppGUI
{
    public partial class CashInForm : Form
    {
        LoadBusinessService businessService = new LoadBusinessService();
        public CashInForm()
        {
            InitializeComponent();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string cash = txtAmount.Text.Trim();
            double amount;

            if (!double.TryParse(cash, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!businessService.CheckCashInAmount(amount))
            {
                MessageBox.Show("ERROR: Enter amount higher than 50", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = AccountData.LoggedInUser;

            if (businessService.UpdateBalance(1, amount, user.phoneNumber, user.pin))
            {
                AccountData.LoggedInUser = businessService.SetUser(user.phoneNumber, user.pin);

                businessService.AddToHistory(AccountData.LoggedInUser, $"CASH IN: You have received {amount}.");

                MessageBox.Show("Cash in successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
            }
            else
            {
                MessageBox.Show("Cash in failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
