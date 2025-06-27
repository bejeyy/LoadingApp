namespace LoadAppGUI
{
    partial class CashInForm
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
            label3 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            link_Back = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAmount);
            panel1.Location = new Point(109, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 142);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 6F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 101);
            label3.Name = "label3";
            label3.Size = new Size(204, 16);
            label3.TabIndex = 2;
            label3.Text = "NOTE: Amount must be higher than 50 pesos.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 27);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 1;
            label2.Text = "Enter amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(51, 52);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(298, 31);
            txtAmount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(109, 117);
            label1.Name = "label1";
            label1.Size = new Size(150, 42);
            label1.TabIndex = 1;
            label1.Text = "Cash In";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(226, 344);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(178, 55);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // link_Back
            // 
            link_Back.ActiveLinkColor = Color.DimGray;
            link_Back.AutoSize = true;
            link_Back.BackColor = Color.Transparent;
            link_Back.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_Back.LinkBehavior = LinkBehavior.NeverUnderline;
            link_Back.LinkColor = SystemColors.ControlLightLight;
            link_Back.Location = new Point(38, 26);
            link_Back.Name = "link_Back";
            link_Back.Size = new Size(54, 65);
            link_Back.TabIndex = 3;
            link_Back.TabStop = true;
            link_Back.Text = "❮";
            link_Back.LinkClicked += link_Back_LinkClicked;
            // 
            // CashInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 463);
            Controls.Add(link_Back);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtAmount;
        private Label label1;
        private Label label3;
        private Button btnConfirm;
        private LinkLabel link_Back;
    }
}