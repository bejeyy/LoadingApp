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
    public partial class ProfileForm : Form
    {

        LoadBusinessService businessService = new LoadBusinessService();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            var user = AccountData.LoggedInUser;

            lblNumber.Text = $"{user.phoneNumber}";
            txtName.Text = user.name;
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            var user = AccountData.LoggedInUser;

            if (txtName.ReadOnly)
            {
                txtName.ReadOnly = false;
                txtName.Enabled = true;
                btnChangeName.Text = "Save Name";
            }
            else
            {

                string newName = txtName.Text.Trim();

                if (String.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("ERROR: Input a name.", "Input a Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                businessService.ChangeName(user.phoneNumber, user.pin, newName);
                AccountData.LoggedInUser = businessService.SetUser(user.phoneNumber, user.pin);

                MessageBox.Show("Name updated sucessfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.ReadOnly = true;
                txtName.Enabled = false;
                btnChangeName.Text = "Edit Name";
            }
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChangePinForm changePinForm = new ChangePinForm();
            changePinForm.Show();
        }
    }
}
