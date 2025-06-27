namespace LoadAppGUI
{
    partial class ChangePinForm
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
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            txtNewPIN = new TextBox();
            label2 = new Label();
            txtCurrentPin = new TextBox();
            label1 = new Label();
            link_Back = new LinkLabel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNewPIN);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCurrentPin);
            panel1.Location = new Point(97, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 224);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.eye;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(368, 139);
            button3.Name = "button3";
            button3.Size = new Size(37, 32);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.eye;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(368, 59);
            button2.Name = "button2";
            button2.Size = new Size(37, 32);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 115);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 7;
            label3.Text = "New PIN";
            // 
            // txtNewPIN
            // 
            txtNewPIN.Location = new Point(64, 140);
            txtNewPIN.Name = "txtNewPIN";
            txtNewPIN.Size = new Size(298, 31);
            txtNewPIN.TabIndex = 6;
            txtNewPIN.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 35);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 5;
            label2.Text = "Current PIN";
            // 
            // txtCurrentPin
            // 
            txtCurrentPin.Location = new Point(64, 60);
            txtCurrentPin.Name = "txtCurrentPin";
            txtCurrentPin.Size = new Size(298, 31);
            txtCurrentPin.TabIndex = 4;
            txtCurrentPin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(97, 95);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 2;
            label1.Text = "Change PIN";
            // 
            // link_Back
            // 
            link_Back.ActiveLinkColor = Color.DimGray;
            link_Back.AutoSize = true;
            link_Back.BackColor = Color.Transparent;
            link_Back.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_Back.LinkBehavior = LinkBehavior.NeverUnderline;
            link_Back.LinkColor = SystemColors.ControlLightLight;
            link_Back.Location = new Point(22, 19);
            link_Back.Name = "link_Back";
            link_Back.Size = new Size(54, 65);
            link_Back.TabIndex = 5;
            link_Back.TabStop = true;
            link_Back.Text = "❮";
            link_Back.LinkClicked += link_Back_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(225, 380);
            button1.Name = "button1";
            button1.Size = new Size(176, 34);
            button1.TabIndex = 6;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChangePinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 445);
            Controls.Add(button1);
            Controls.Add(link_Back);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePinForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private LinkLabel link_Back;
        private Label label3;
        private TextBox txtNewPIN;
        private Label label2;
        private TextBox txtCurrentPin;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}