namespace LoadAppGUI
{
    partial class SendCashForm
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
            link_Back = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            txtNumber = new TextBox();
            btnConfirm = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // link_Back
            // 
            link_Back.ActiveLinkColor = Color.DimGray;
            link_Back.AutoSize = true;
            link_Back.BackColor = Color.Transparent;
            link_Back.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_Back.LinkBehavior = LinkBehavior.NeverUnderline;
            link_Back.LinkColor = SystemColors.ControlLightLight;
            link_Back.Location = new Point(36, 28);
            link_Back.Name = "link_Back";
            link_Back.Size = new Size(58, 70);
            link_Back.TabIndex = 4;
            link_Back.TabStop = true;
            link_Back.Text = "❮";
            link_Back.LinkClicked += link_Back_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(110, 130);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 5;
            label1.Text = "Send Cash";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNumber);
            panel1.Location = new Point(110, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 201);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 107);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 3;
            label3.Text = "Amount to Send";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(51, 132);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(298, 31);
            txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 27);
            label2.Name = "label2";
            label2.Size = new Size(116, 22);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(51, 52);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Ex. 09123456789";
            txtNumber.Size = new Size(298, 31);
            txtNumber.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(216, 401);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(178, 55);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // SendCashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 500);
            Controls.Add(btnConfirm);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(link_Back);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SendCashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SendCashForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel link_Back;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox txtAmount;
        private Label label2;
        private TextBox txtNumber;
        private Button btnConfirm;
    }
}