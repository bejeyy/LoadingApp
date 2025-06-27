namespace LoadAppGUI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txt_regNum = new TextBox();
            txt_regName = new TextBox();
            txt_regPin = new TextBox();
            btn_Register = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // txt_regNum
            // 
            txt_regNum.Location = new Point(157, 137);
            txt_regNum.Name = "txt_regNum";
            txt_regNum.Size = new Size(293, 31);
            txt_regNum.TabIndex = 0;
            // 
            // txt_regName
            // 
            txt_regName.Location = new Point(157, 231);
            txt_regName.Name = "txt_regName";
            txt_regName.Size = new Size(293, 31);
            txt_regName.TabIndex = 1;
            // 
            // txt_regPin
            // 
            txt_regPin.Location = new Point(157, 316);
            txt_regPin.Name = "txt_regPin";
            txt_regPin.Size = new Size(293, 31);
            txt_regPin.TabIndex = 2;
            // 
            // btn_Register
            // 
            btn_Register.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Register.Location = new Point(300, 404);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(148, 41);
            btn_Register.TabIndex = 3;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(159, 109);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 4;
            label1.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(159, 203);
            label2.Name = "label2";
            label2.Size = new Size(51, 22);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(157, 291);
            label3.Name = "label3";
            label3.Size = new Size(35, 22);
            label3.TabIndex = 6;
            label3.Text = "PIN";
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.Location = new Point(159, 404);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(145, 41);
            btn_Back.TabIndex = 7;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 520);
            Controls.Add(btn_Back);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Register);
            Controls.Add(txt_regPin);
            Controls.Add(txt_regName);
            Controls.Add(txt_regNum);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_regNum;
        private TextBox txt_regName;
        private TextBox txt_regPin;
        private Button btn_Register;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Back;
    }
}