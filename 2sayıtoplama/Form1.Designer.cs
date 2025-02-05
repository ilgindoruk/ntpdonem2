namespace _2sayıtoplama
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
            lblsayı1 = new Label();
            lblsayı2 = new Label();
            bttntoplam = new Button();
            txtS1 = new TextBox();
            txtS2 = new TextBox();
            txtSonuc = new TextBox();
            SuspendLayout();
            // 
            // lblsayı1
            // 
            lblsayı1.AutoSize = true;
            lblsayı1.Font = new Font("Segoe UI Historic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblsayı1.Location = new Point(1, 55);
            lblsayı1.Name = "lblsayı1";
            lblsayı1.Size = new Size(124, 50);
            lblsayı1.TabIndex = 0;
            lblsayı1.Text = "Sayı 1";
            // 
            // lblsayı2
            // 
            lblsayı2.AutoSize = true;
            lblsayı2.Font = new Font("Segoe UI Historic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblsayı2.Location = new Point(1, 140);
            lblsayı2.Name = "lblsayı2";
            lblsayı2.Size = new Size(117, 47);
            lblsayı2.TabIndex = 1;
            lblsayı2.Text = "Sayı 2";
            // 
            // bttntoplam
            // 
            bttntoplam.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bttntoplam.Location = new Point(1, 295);
            bttntoplam.Name = "bttntoplam";
            bttntoplam.Size = new Size(148, 54);
            bttntoplam.TabIndex = 2;
            bttntoplam.Text = "Toplam";
            bttntoplam.UseVisualStyleBackColor = true;
            bttntoplam.Click += bttntoplam_Click;
            // 
            // txtS1
            // 
            txtS1.Location = new Point(158, 70);
            txtS1.Name = "txtS1";
            txtS1.Size = new Size(100, 23);
            txtS1.TabIndex = 3;
            // 
            // txtS2
            // 
            txtS2.Location = new Point(158, 154);
            txtS2.Name = "txtS2";
            txtS2.Size = new Size(100, 23);
            txtS2.TabIndex = 4;
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(158, 317);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(100, 23);
            txtSonuc.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 450);
            Controls.Add(txtSonuc);
            Controls.Add(txtS2);
            Controls.Add(txtS1);
            Controls.Add(bttntoplam);
            Controls.Add(lblsayı2);
            Controls.Add(lblsayı1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsayı1;
        private Label lblsayı2;
        private Button bttntoplam;
        private TextBox txtS1;
        private TextBox txtS2;
        private TextBox txtSonuc;
    }
}