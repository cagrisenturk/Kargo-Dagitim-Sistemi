
namespace Prolab1
{
    partial class SifreDegistirme
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
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.degistirButton = new System.Windows.Forms.Button();
            this.yeniSifreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.HideSelection = false;
            this.sifreTextBox.Location = new System.Drawing.Point(314, 147);
            this.sifreTextBox.Multiline = true;
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(139, 25);
            this.sifreTextBox.TabIndex = 7;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(314, 89);
            this.kullaniciAdiTextBox.Multiline = true;
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(139, 25);
            this.kullaniciAdiTextBox.TabIndex = 6;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Black;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.White;
            this.sifre.Location = new System.Drawing.Point(137, 147);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(57, 25);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.kullaniciAdi.Location = new System.Drawing.Point(137, 89);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(132, 25);
            this.kullaniciAdi.TabIndex = 4;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // degistirButton
            // 
            this.degistirButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.degistirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degistirButton.Location = new System.Drawing.Point(314, 246);
            this.degistirButton.Name = "degistirButton";
            this.degistirButton.Size = new System.Drawing.Size(139, 46);
            this.degistirButton.TabIndex = 13;
            this.degistirButton.Text = "Değiştir";
            this.degistirButton.UseVisualStyleBackColor = false;
            this.degistirButton.Click += new System.EventHandler(this.degistirButton_Click);
            // 
            // yeniSifreTextBox
            // 
            this.yeniSifreTextBox.HideSelection = false;
            this.yeniSifreTextBox.Location = new System.Drawing.Point(314, 190);
            this.yeniSifreTextBox.Multiline = true;
            this.yeniSifreTextBox.Name = "yeniSifreTextBox";
            this.yeniSifreTextBox.PasswordChar = '*';
            this.yeniSifreTextBox.Size = new System.Drawing.Size(139, 25);
            this.yeniSifreTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yeni Şifre";
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.degistirButton);
            this.Controls.Add(this.yeniSifreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Button degistirButton;
        private System.Windows.Forms.TextBox yeniSifreTextBox;
        private System.Windows.Forms.Label label2;
    }
}