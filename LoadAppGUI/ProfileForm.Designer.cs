namespace LoadAppGUI
{
    partial class ProfileForm
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
            link_Back = new LinkLabel();
            btnChangeName = new Button();
            btnChangePin = new Button();
            lblNumber = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BackgroundImage = Properties.Resources.Profile_image;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(235, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 150);
            panel1.TabIndex = 0;
            // 
            // link_Back
            // 
            link_Back.ActiveLinkColor = Color.DimGray;
            link_Back.AutoSize = true;
            link_Back.BackColor = Color.Transparent;
            link_Back.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_Back.LinkBehavior = LinkBehavior.NeverUnderline;
            link_Back.LinkColor = SystemColors.ControlLightLight;
            link_Back.Location = new Point(28, 20);
            link_Back.Name = "link_Back";
            link_Back.Size = new Size(54, 65);
            link_Back.TabIndex = 4;
            link_Back.TabStop = true;
            link_Back.Text = "❮";
            link_Back.LinkClicked += link_Back_LinkClicked;
            // 
            // btnChangeName
            // 
            btnChangeName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangeName.Location = new Point(141, 342);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(165, 43);
            btnChangeName.TabIndex = 5;
            btnChangeName.Text = "Change Name";
            btnChangeName.UseVisualStyleBackColor = true;
            btnChangeName.Click += btnChangeName_Click;
            // 
            // btnChangePin
            // 
            btnChangePin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangePin.Location = new Point(326, 342);
            btnChangePin.Name = "btnChangePin";
            btnChangePin.Size = new Size(165, 43);
            btnChangePin.TabIndex = 6;
            btnChangePin.Text = "Change PIN";
            btnChangePin.UseVisualStyleBackColor = true;
            btnChangePin.Click += btnChangePin_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.ForeColor = SystemColors.ControlLightLight;
            lblNumber.Location = new Point(239, 255);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(145, 28);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "TELEPONO";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(202, 299);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(232, 24);
            txtName.TabIndex = 7;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 426);
            Controls.Add(txtName);
            Controls.Add(btnChangePin);
            Controls.Add(btnChangeName);
            Controls.Add(link_Back);
            Controls.Add(lblNumber);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel link_Back;
        private Button btnChangeName;
        private Button btnChangePin;
        private Label lblNumber;
        private TextBox txtName;
    }
}