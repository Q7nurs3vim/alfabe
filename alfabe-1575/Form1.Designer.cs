namespace alfabe_1575
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
            cbAlfabe = new ComboBox();
            btnKontrol = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 0;
            label1.Text = "Half Seçiniz :";
            // 
            // cbAlfabe
            // 
            cbAlfabe.FormattingEnabled = true;
            cbAlfabe.Items.AddRange(new object[] { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" });
            cbAlfabe.Location = new Point(126, 29);
            cbAlfabe.Name = "cbAlfabe";
            cbAlfabe.Size = new Size(151, 28);
            cbAlfabe.TabIndex = 1;
            // 
            // btnKontrol
            // 
            btnKontrol.BackColor = Color.DarkCyan;
            btnKontrol.Location = new Point(125, 72);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(152, 36);
            btnKontrol.TabIndex = 2;
            btnKontrol.Text = "KONTROL ET ";
            btnKontrol.UseVisualStyleBackColor = false;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSonuc.Location = new Point(14, 127);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(66, 23);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Sonuç :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(452, 218);
            Controls.Add(lblSonuc);
            Controls.Add(btnKontrol);
            Controls.Add(cbAlfabe);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbAlfabe;
        private Button btnKontrol;
        private Label lblSonuc;
    }
}