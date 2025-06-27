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
    public partial class SendCashForm : Form
    {

        LoadBusinessService businessService = new LoadBusinessService();
        public SendCashForm()
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
            string phoneNumber = txtNumber.Text.Trim();
            string cash = txtAmount.Text.Trim();
            double amount;

            if(!businessService.NumberConfirmation(phoneNumber))
            {
                MessageBox.Show("ERROR: Please enter a valid 11 digits number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(cash, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = AccountData.LoggedInUser;

            if (businessService.UpdateBalance(2, amount, user.phoneNumber, user.pin))
            {
                AccountData.LoggedInUser = businessService.SetUser(user.phoneNumber, user.pin);

                businessService.AddToHistory(AccountData.LoggedInUser, $"SEND CASH: You have sent {amount} to {phoneNumber}.");
                MessageBox.Show($"Successfully sent cash to {phoneNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumber.Clear();
                txtAmount.Clear();
            }
        }
    }
}
