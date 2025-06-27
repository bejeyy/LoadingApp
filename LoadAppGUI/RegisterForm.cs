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
    public partial class RegisterForm : Form
    {
        LoadBusinessService businessService = new LoadBusinessService();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_regNum.Text.Trim();
            string name = txt_regName.Text.Trim();
            string PIN = txt_regPin.Text.Trim();

            if (!businessService.NumberConfirmation(phoneNumber))
            {
                MessageBox.Show("ERROR: Enter a valid number with 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (businessService.PhoneNumberExist(phoneNumber))
            {
                MessageBox.Show("ERROR: Account number already exist.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("ERROR: Enter a Name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!businessService.IsValidPin(PIN))
            {
                MessageBox.Show("Enter a valid PIN (4 to 6 digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            businessService.AddUserAccount(phoneNumber, name, PIN);
            MessageBox.Show("Account registered. You can now Log In.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
