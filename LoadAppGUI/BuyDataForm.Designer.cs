namespace LoadAppGUI
{
    partial class BuyDataForm
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
            label1 = new Label();
            panel1 = new Panel();
            lbOffers = new ListBox();
            cbNetworks = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtNumber = new TextBox();
            link_Back = new LinkLabel();
            btnBuy = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(108, 142);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 6;
            label1.Text = "Buy Data";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbOffers);
            panel1.Controls.Add(cbNetworks);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNumber);
            panel1.Location = new Point(108, 198);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 399);
            panel1.TabIndex = 7;
            // 
            // lbOffers
            // 
            lbOffers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOffers.FormattingEnabled = true;
            lbOffers.ItemHeight = 25;
            lbOffers.Location = new Point(53, 191);
            lbOffers.Name = "lbOffers";
            lbOffers.Size = new Size(296, 179);
            lbOffers.TabIndex = 5;
            // 
            // cbNetworks
            // 
            cbNetworks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbNetworks.FormattingEnabled = true;
            cbNetworks.Items.AddRange(new object[] { "Smart", "Globe", "GOMO", "DITO" });
            cbNetworks.Location = new Point(51, 127);
            cbNetworks.Name = "cbNetworks";
            cbNetworks.Size = new Size(182, 33);
            cbNetworks.TabIndex = 4;
            cbNetworks.SelectedIndexChanged += cbNetworks_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 93);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 3;
            label3.Text = "Network";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 16);
            label2.Name = "label2";
            label2.Size = new Size(116, 22);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(51, 41);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Ex. 09123456789";
            txtNumber.Size = new Size(298, 31);
            txtNumber.TabIndex = 0;
            // 
            // link_Back
            // 
            link_Back.ActiveLinkColor = Color.DimGray;
            link_Back.AutoSize = true;
            link_Back.BackColor = Color.Transparent;
            link_Back.Font = new Font("Segoe UI", 34F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_Back.LinkBehavior = LinkBehavior.NeverUnderline;
            link_Back.LinkColor = SystemColors.ControlLightLight;
            link_Back.Location = new Point(27, 42);
            link_Back.Name = "link_Back";
            link_Back.Size = new Size(75, 91);
            link_Back.TabIndex = 8;
            link_Back.TabStop = true;
            link_Back.Text = "❮";
            link_Back.LinkClicked += link_Back_LinkClicked;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(225, 627);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(178, 55);
            btnBuy.TabIndex = 9;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // BuyDataForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 713);
            Controls.Add(btnBuy);
            Controls.Add(link_Back);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuyDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuyDataForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtNumber;
        private ComboBox cbNetworks;
        private LinkLabel link_Back;
        private ListBox lbOffers;
        private Button btnBuy;
    }
}