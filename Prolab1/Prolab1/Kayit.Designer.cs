
namespace Prolab1
{
    partial class Kayit
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
            this.sifre = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifre2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kayitOlButton = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Black;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.White;
            this.sifre.Location = new System.Drawing.Point(95, 184);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(57, 25);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.kullaniciAdi.Location = new System.Drawing.Point(95, 70);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(132, 25);
            this.kullaniciAdi.TabIndex = 2;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.HideSelection = false;
            this.sifreTextBox.Location = new System.Drawing.Point(272, 184);
            this.sifreTextBox.Multiline = true;
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(139, 25);
            this.sifreTextBox.TabIndex = 5;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(272, 74);
            this.kullaniciAdiTextBox.Multiline = true;
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(139, 25);
            this.kullaniciAdiTextBox.TabIndex = 4;
            // 
            // sifre2TextBox
            // 
            this.sifre2TextBox.HideSelection = false;
            this.sifre2TextBox.Location = new System.Drawing.Point(598, 184);
            this.sifre2TextBox.Multiline = true;
            this.sifre2TextBox.Name = "sifre2TextBox";
            this.sifre2TextBox.PasswordChar = '*';
            this.sifre2TextBox.Size = new System.Drawing.Size(139, 25);
            this.sifre2TextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifreyi Onayla";
            // 
            // kayitOlButton
            // 
            this.kayitOlButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kayitOlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOlButton.Location = new System.Drawing.Point(336, 243);
            this.kayitOlButton.Name = "kayitOlButton";
            this.kayitOlButton.Size = new System.Drawing.Size(117, 46);
            this.kayitOlButton.TabIndex = 8;
            this.kayitOlButton.Text = "Kayıt ol";
            this.kayitOlButton.UseVisualStyleBackColor = false;
            this.kayitOlButton.Click += new System.EventHandler(this.kayitOlButton_Click);
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.BackColor = System.Drawing.Color.Black;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.ForeColor = System.Drawing.Color.White;
            this.mail.Location = new System.Drawing.Point(95, 129);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(52, 25);
            this.mail.TabIndex = 9;
            this.mail.Text = "Mail";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(272, 129);
            this.mailTextBox.Multiline = true;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(139, 25);
            this.mailTextBox.TabIndex = 10;
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.kayitOlButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre2TextBox);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox sifre2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitOlButton;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox mailTextBox;
    }
}