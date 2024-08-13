namespace LogsForm
{
    partial class Form1
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
            label1 = new Label();
            cbSeverity = new ComboBox();
            tbInfo = new TextBox();
            btnLogEintrag = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 52);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 10;
            label1.Text = "Severity";
            // 
            // cbSeverity
            // 
            cbSeverity.FormattingEnabled = true;
            cbSeverity.Location = new Point(74, 70);
            cbSeverity.Name = "cbSeverity";
            cbSeverity.Size = new Size(121, 23);
            cbSeverity.TabIndex = 9;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(216, 70);
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(262, 23);
            tbInfo.TabIndex = 8;
            // 
            // btnLogEintrag
            // 
            btnLogEintrag.Location = new Point(216, 111);
            btnLogEintrag.Name = "btnLogEintrag";
            btnLogEintrag.Size = new Size(262, 23);
            btnLogEintrag.TabIndex = 7;
            btnLogEintrag.Text = "Log Eintrag hinzufügen";
            btnLogEintrag.UseVisualStyleBackColor = true;
            btnLogEintrag.Click += btnLogEintrag_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(552, 186);
            Controls.Add(label1);
            Controls.Add(cbSeverity);
            Controls.Add(tbInfo);
            Controls.Add(btnLogEintrag);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbSeverity;
        private TextBox tbInfo;
        private Button btnLogEintrag;
    }
}
