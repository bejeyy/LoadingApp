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
    public partial class ChangePinForm : Form
    {

        LoadBusinessService businessService = new LoadBusinessService();
        public ChangePinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPin = txtCurrentPin.Text.Trim();
            string newPin = txtNewPIN.Text.Trim();
            var user = AccountData.LoggedInUser;

            if (!businessService.CurrentPinVerification(currentPin))
            {
                MessageBox.Show("ERROR: Wrong PIN.", "Wrong PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPin.Clear();
                return;
            }

            if (!businessService.IsValidPin(newPin))
            {
                MessageBox.Show("ERROR: Enter a valid 4-6 digit PIN.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            businessService.ChangePIN(user.phoneNumber, user.pin, newPin);
            AccountData.LoggedInUser = businessService.SetUser(user.phoneNumber, newPin);

            MessageBox.Show("PIN updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCurrentPin.Clear();
            txtNewPIN.Clear();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCurrentPin.UseSystemPasswordChar == true)
            {
                txtCurrentPin.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPin.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNewPIN.UseSystemPasswordChar == true)
            {
                txtNewPIN.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPIN.UseSystemPasswordChar = true;
            }
        }
    }
}
