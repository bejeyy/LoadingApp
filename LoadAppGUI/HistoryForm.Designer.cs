namespace LoadAppGUI
{
    partial class HistoryForm
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
            lbHistory = new ListBox();
            label1 = new Label();
            link_Back = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbHistory
            // 
            lbHistory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHistory.FormattingEnabled = true;
            lbHistory.ItemHeight = 25;
            lbHistory.Location = new Point(89, 162);
            lbHistory.Name = "lbHistory";
            lbHistory.Size = new Size(452, 304);
            lbHistory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(89, 113);
            label1.Name = "label1";
            label1.Size = new Size(299, 37);
            label1.TabIndex = 6;
            label1.Text = "Your Transactions";
            // 
            // link_Back
            // 
            link_Back.ActiveLinkColor = Color.DimGray;
            link_Back.AutoSize = true;
            link_Back.BackColor = Color.Transparent;
            link_Back.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_Back.LinkBehavior = LinkBehavior.NeverUnderline;
            link_Back.LinkColor = SystemColors.ControlLightLight;
            link_Back.Location = new Point(30, 32);
            link_Back.Name = "link_Back";
            link_Back.Size = new Size(58, 70);
            link_Back.TabIndex = 7;
            link_Back.TabStop = true;
            link_Back.Text = "❮";
            link_Back.LinkClicked += link_Back_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(372, 487);
            button1.Name = "button1";
            button1.Size = new Size(169, 49);
            button1.TabIndex = 8;
            button1.Text = "Clear History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClear;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoadApp_bgimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 566);
            Controls.Add(button1);
            Controls.Add(link_Back);
            Controls.Add(label1);
            Controls.Add(lbHistory);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistoryForm";
            Load += HistoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbHistory;
        private Label label1;
        private LinkLabel link_Back;
        private Button button1;
    }
}