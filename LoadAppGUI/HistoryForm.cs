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
    public partial class HistoryForm : Form
    {

        LoadBusinessService businessService = new LoadBusinessService();
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();

            foreach (var entry in AccountData.LoggedInUser.history)
            {
                lbHistory.Items.Add(entry);
            }
        }

        private void btnClear(object sender, EventArgs e)
        {
            var user = AccountData.LoggedInUser;

            businessService.ClearHistory(user);
            lbHistory.Items.Clear();
            MessageBox.Show("History cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
