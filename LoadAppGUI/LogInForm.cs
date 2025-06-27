using Load_BusinessDataLogic;

namespace LoadAppGUI
{
    public partial class LogInForm : Form
    {
        LoadBusinessService loadBusinessService = new LoadBusinessService();
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_phoneNum.Text.Trim();
            string PIN = txt_Pin.Text.Trim();

            if (!loadBusinessService.AccountVerification(phoneNumber, PIN))
            {
                MessageBox.Show("Invalid phone number or PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccountData.LoggedInUser = loadBusinessService.SetUser(phoneNumber, PIN);
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Dashboard mainDashboard = new Dashboard();
                mainDashboard.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_Pin.UseSystemPasswordChar == true)
            {
                txt_Pin.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Pin.UseSystemPasswordChar = true;
            }
        }
    }
}
