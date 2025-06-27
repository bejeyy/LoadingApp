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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoadAppGUI
{
    public partial class BuyDataForm : Form
    {
        string[] dataAmounts = { "500mb", "1000mb", "3000mb", "6000mb", "12000mb" };
        string[] smartPromos = { "GigaChad30", "GigaChad49", "GigaChad99", "GigaChad149", "GigaChad199" };
        string[] globePromos = { "GoSURF30", "GoSURF49", "GoSURF99", "GoSURF149", "GoSURF199" };
        string[] gomoPromos = { "GomuGomuNo30", "GomuGomuNo49", "GomuGomuNo99", "GomuGomuNo149", "GomuGomuNo199" };
        string[] ditoPromos = { "Level30", "Level49", "Level99", "Level149", "Level199" };

        LoadBusinessService businessService = new LoadBusinessService();
        public BuyDataForm()
        {
            InitializeComponent();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void cbNetworks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOffers.Items.Clear();

            string selectedNetwork = cbNetworks.SelectedItem.ToString();
            string[] promos = null;

            if (selectedNetwork == "Smart")
            {
                promos = smartPromos;
            }
            else if (selectedNetwork == "Globe")
            {
                promos = globePromos;
            }
            else if (selectedNetwork == "GOMO")
            {
                promos = gomoPromos;
            }
            else if (selectedNetwork == "DITO")
            {
                promos = ditoPromos;
            }

            if (promos != null)
            {
                for (int i = 0; i < promos.Length; i++)
                {
                    string offer = (i + 1) + ") " + promos[i] + " (" + dataAmounts[i] + ")";
                    lbOffers.Items.Add(offer);
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string network = cbNetworks.SelectedItem.ToString();
            int selectedIndex = lbOffers.SelectedIndex;

            if (string.IsNullOrEmpty(network) || selectedIndex < 0)
            {
                MessageBox.Show("Please select a network and a promo.");
                return;
            }

            string phone = AccountData.LoggedInUser.phoneNumber;
            string pin = AccountData.LoggedInUser.pin;
            int action = selectedIndex + 1;

            bool success = businessService.BuyingDataProcess(action, phone, pin);

            if (success)
            {
                AccountData.LoggedInUser = businessService.SetUser(phone, pin);

                string[] dataAmounts = { "500mb", "1000mb", "3000mb", "6000mb", "12000mb" };
                string[] selectedPromos = null;

                if (network == "Smart")
                {
                    selectedPromos = smartPromos;
                }
                else if (network == "Globe")
                {
                    selectedPromos = globePromos;
                }
                else if (network == "GOMO")
                {
                    selectedPromos = gomoPromos;
                }
                else if (network == "DITO")
                {
                    selectedPromos = ditoPromos;
                }

                string boughtPromo = selectedPromos[selectedIndex];
                string boughtData = dataAmounts[selectedIndex];

                string historyText = $"{network.ToUpper()}: You have bought {boughtPromo} ({boughtData})";
                businessService.AddToHistory(AccountData.LoggedInUser, historyText);

                MessageBox.Show($"Purchase successful!\n{boughtPromo} ({boughtData})\n\nBalance: ₱{AccountData.LoggedInUser.balance}\nData: {AccountData.LoggedInUser.data}mb", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
