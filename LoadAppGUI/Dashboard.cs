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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var user = AccountData.LoggedInUser;

            lbl_Welcome.Text = $"Welcome, {user.name}";
            lbl_Balance.Text = $"Balance: ₱{user.balance}";
        }

        private void btn_SendCash_Click(object sender, EventArgs e)
        {
            this.Hide();

            SendCashForm sendCashForm = new SendCashForm();
            sendCashForm.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            bool isVisible = btn_Profile.Visible;

            btn_Profile.Visible = !isVisible;
            btn_LogOut.Visible = !isVisible;
        }

        private void btn_CashIn_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashInForm cashInForm = new CashInForm();
            cashInForm.Show();
        }

        private void btn_BuyData_Click(object sender, EventArgs e)
        {
            this.Hide();

            BuyDataForm buyDataForm = new BuyDataForm();
            buyDataForm.Show();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            this.Hide();

            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
        }

        private void btn_Balance_Click(object sender, EventArgs e)
        {
            var user = AccountData.LoggedInUser;

            MessageBox.Show($"Balance: ₱{user.balance}\nData: {user.data}mb", "Your Balance", MessageBoxButtons.OK);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            AccountData.LoggedInUser = null;
            this.Close();

            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }
    }
}
