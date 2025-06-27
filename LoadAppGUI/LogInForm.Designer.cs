namespace LoadAppGUI
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_phoneNum = new TextBox();
            txt_Pin = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            SuspendLayout();
            // 
            // txt_phoneNum
            // 
            txt_phoneNum.Location = new Point(204, 304);
            txt_phoneNum.Name = "txt_phoneNum";
            txt_phoneNum.PlaceholderText = "Ex. 09123456789";
            txt_phoneNum.Size = new Size(227, 31);
            txt_phoneNum.TabIndex = 0;
            // 
            // txt_Pin
            // 
            txt_Pin.Location = new Point(204, 380);
            txt_Pin.Name = "txt_Pin";
            txt_Pin.Size = new Size(227, 31);
            txt_Pin.TabIndex = 1;
            txt_Pin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(82, 309);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 2;
            label1.Text = "Phone Number";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(255, 454);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(163, 385);
            label2.Name = "label2";
            label2.Size = new Size(35, 22);
            label2.TabIndex = 5;
            label2.Text = "PIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(178, 525);
            label3.Name = "label3";
            label3.Size = new Size(161, 22);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Arial Narrow", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(334, 525);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 22);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.eye;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(437, 379);
            button2.Name = "button2";
            button2.Size = new Size(37, 32);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(618, 784);
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txt_Pin);
            Controls.Add(txt_phoneNum);
            DoubleBuffered = true;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_phoneNum;
        private TextBox txt_Pin;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button2;
    }
}
