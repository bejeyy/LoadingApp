namespace LoadAppGUI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lbl_Balance = new Label();
            lbl_Welcome = new Label();
            btn_CashIn = new Button();
            btn_SendCash = new Button();
            btn_BuyData = new Button();
            btn_History = new Button();
            btn_Balance = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            btn_Menu = new Button();
            btn_Profile = new Button();
            btn_LogOut = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_Balance);
            panel1.Location = new Point(85, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 72);
            panel1.TabIndex = 0;
            // 
            // lbl_Balance
            // 
            lbl_Balance.AutoSize = true;
            lbl_Balance.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Balance.Location = new Point(3, 16);
            lbl_Balance.Name = "lbl_Balance";
            lbl_Balance.Size = new Size(183, 37);
            lbl_Balance.TabIndex = 0;
            lbl_Balance.Text = "Balance: ₱";
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.BackColor = Color.Transparent;
            lbl_Welcome.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Welcome.ForeColor = SystemColors.ControlLightLight;
            lbl_Welcome.Location = new Point(86, 152);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(117, 26);
            lbl_Welcome.TabIndex = 1;
            lbl_Welcome.Text = "Welcome,";
            // 
            // btn_CashIn
            // 
            btn_CashIn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CashIn.Location = new Point(194, 290);
            btn_CashIn.Name = "btn_CashIn";
            btn_CashIn.Size = new Size(318, 61);
            btn_CashIn.TabIndex = 2;
            btn_CashIn.Text = "Cash In";
            btn_CashIn.UseVisualStyleBackColor = true;
            btn_CashIn.Click += btn_CashIn_Click;
            // 
            // btn_SendCash
            // 
            btn_SendCash.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SendCash.Location = new Point(194, 375);
            btn_SendCash.Name = "btn_SendCash";
            btn_SendCash.Size = new Size(318, 61);
            btn_SendCash.TabIndex = 3;
            btn_SendCash.Text = "Send Cash";
            btn_SendCash.UseVisualStyleBackColor = true;
            btn_SendCash.Click += btn_SendCash_Click;
            // 
            // btn_BuyData
            // 
            btn_BuyData.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BuyData.Location = new Point(194, 456);
            btn_BuyData.Name = "btn_BuyData";
            btn_BuyData.Size = new Size(318, 61);
            btn_BuyData.TabIndex = 4;
            btn_BuyData.Text = "Buy Data";
            btn_BuyData.UseVisualStyleBackColor = true;
            btn_BuyData.Click += btn_BuyData_Click;
            // 
            // btn_History
            // 
            btn_History.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_History.Location = new Point(194, 535);
            btn_History.Name = "btn_History";
            btn_History.Size = new Size(318, 61);
            btn_History.TabIndex = 5;
            btn_History.Text = "History";
            btn_History.UseVisualStyleBackColor = true;
            btn_History.Click += btn_History_Click;
            // 
            // btn_Balance
            // 
            btn_Balance.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Balance.Location = new Point(194, 613);
            btn_Balance.Name = "btn_Balance";
            btn_Balance.Size = new Size(318, 61);
            btn_Balance.TabIndex = 6;
            btn_Balance.Text = "View Balance";
            btn_Balance.UseVisualStyleBackColor = true;
            btn_Balance.Click += btn_Balance_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.CashIn_image;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(116, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(72, 61);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.SendCash_image;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(116, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(72, 61);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.Sim_image;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(116, 456);
            panel4.Name = "panel4";
            panel4.Size = new Size(72, 61);
            panel4.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BackgroundImage = Properties.Resources.History_image;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(116, 535);
            panel5.Name = "panel5";
            panel5.Size = new Size(72, 61);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BackgroundImage = Properties.Resources.Wallet_image;
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(116, 613);
            panel6.Name = "panel6";
            panel6.Size = new Size(72, 61);
            panel6.TabIndex = 11;
            // 
            // btn_Menu
            // 
            btn_Menu.BackgroundImage = Properties.Resources.Profile_image;
            btn_Menu.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Menu.FlatStyle = FlatStyle.Popup;
            btn_Menu.Location = new Point(32, 32);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(68, 61);
            btn_Menu.TabIndex = 12;
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // btn_Profile
            // 
            btn_Profile.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Profile.Location = new Point(106, 32);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(139, 34);
            btn_Profile.TabIndex = 13;
            btn_Profile.Text = "Profile";
            btn_Profile.UseVisualStyleBackColor = true;
            btn_Profile.Visible = false;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // btn_LogOut
            // 
            btn_LogOut.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_LogOut.Location = new Point(106, 72);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(139, 34);
            btn_LogOut.TabIndex = 14;
            btn_LogOut.Text = "Log out";
            btn_LogOut.UseVisualStyleBackColor = true;
            btn_LogOut.Visible = false;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(618, 784);
            Controls.Add(btn_LogOut);
            Controls.Add(btn_Profile);
            Controls.Add(btn_Menu);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btn_Balance);
            Controls.Add(btn_History);
            Controls.Add(btn_BuyData);
            Controls.Add(btn_SendCash);
            Controls.Add(btn_CashIn);
            Controls.Add(lbl_Welcome);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_Balance;
        private Label lbl_Welcome;
        private Button btn_CashIn;
        private Button btn_SendCash;
        private Button btn_BuyData;
        private Button btn_History;
        private Button btn_Balance;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btn_Menu;
        private Button btn_Profile;
        private Button btn_LogOut;
    }
}