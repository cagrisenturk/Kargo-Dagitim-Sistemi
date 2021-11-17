
namespace Prolab1
{
    partial class AnaSayfa
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTiklama = new System.Windows.Forms.CheckBox();
            this.adresText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonKargoEkle = new System.Windows.Forms.Button();
            this.buttonKargolariGetir = new System.Windows.Forms.Button();
            this.groupBoxBilgiler = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSahibi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKargoSil = new System.Windows.Forms.Button();
            this.buttonKargoGuncelle = new System.Windows.Forms.Button();
            this.groupBoxBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(366, 489);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 15;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(366, 489);
            this.map.TabIndex = 1;
            this.map.Zoom = 13D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(397, 62);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 22);
            this.yTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(372, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "y";
            // 
            // xTextBox1
            // 
            this.xTextBox1.Location = new System.Drawing.Point(397, 12);
            this.xTextBox1.Name = "xTextBox1";
            this.xTextBox1.Size = new System.Drawing.Size(100, 22);
            this.xTextBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            // 
            // checkBoxTiklama
            // 
            this.checkBoxTiklama.AutoSize = true;
            this.checkBoxTiklama.ForeColor = System.Drawing.Color.White;
            this.checkBoxTiklama.Location = new System.Drawing.Point(672, 215);
            this.checkBoxTiklama.Name = "checkBoxTiklama";
            this.checkBoxTiklama.Size = new System.Drawing.Size(190, 21);
            this.checkBoxTiklama.TabIndex = 23;
            this.checkBoxTiklama.Text = "Tıklayarak Konum Seçme";
            this.checkBoxTiklama.UseVisualStyleBackColor = true;
            // 
            // adresText
            // 
            this.adresText.Location = new System.Drawing.Point(711, 12);
            this.adresText.Name = "adresText";
            this.adresText.Size = new System.Drawing.Size(151, 197);
            this.adresText.TabIndex = 22;
            this.adresText.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(389, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Adresi Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKargoEkle
            // 
            this.buttonKargoEkle.BackColor = System.Drawing.Color.White;
            this.buttonKargoEkle.Location = new System.Drawing.Point(389, 138);
            this.buttonKargoEkle.Name = "buttonKargoEkle";
            this.buttonKargoEkle.Size = new System.Drawing.Size(133, 34);
            this.buttonKargoEkle.TabIndex = 24;
            this.buttonKargoEkle.Text = "Kargo Ekle";
            this.buttonKargoEkle.UseVisualStyleBackColor = false;
            this.buttonKargoEkle.Click += new System.EventHandler(this.buttonKargoEkle_Click);
            // 
            // buttonKargolariGetir
            // 
            this.buttonKargolariGetir.BackColor = System.Drawing.Color.White;
            this.buttonKargolariGetir.Location = new System.Drawing.Point(389, 178);
            this.buttonKargolariGetir.Name = "buttonKargolariGetir";
            this.buttonKargolariGetir.Size = new System.Drawing.Size(133, 34);
            this.buttonKargolariGetir.TabIndex = 25;
            this.buttonKargolariGetir.Text = "Kargolari Getir";
            this.buttonKargolariGetir.UseVisualStyleBackColor = false;
            this.buttonKargolariGetir.Click += new System.EventHandler(this.buttonKargolariGetir_Click);
            // 
            // groupBoxBilgiler
            // 
            this.groupBoxBilgiler.BackColor = System.Drawing.Color.White;
            this.groupBoxBilgiler.Controls.Add(this.dataGridView1);
            this.groupBoxBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxBilgiler.ForeColor = System.Drawing.Color.Black;
            this.groupBoxBilgiler.Location = new System.Drawing.Point(394, 242);
            this.groupBoxBilgiler.Name = "groupBoxBilgiler";
            this.groupBoxBilgiler.Size = new System.Drawing.Size(450, 226);
            this.groupBoxBilgiler.TabIndex = 26;
            this.groupBoxBilgiler.TabStop = false;
            this.groupBoxBilgiler.Text = "KARGOLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxSahibi
            // 
            this.textBoxSahibi.Location = new System.Drawing.Point(605, 12);
            this.textBoxSahibi.Name = "textBoxSahibi";
            this.textBoxSahibi.Size = new System.Drawing.Size(100, 22);
            this.textBoxSahibi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(503, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Kargo Sahibi";
            // 
            // buttonKargoSil
            // 
            this.buttonKargoSil.BackColor = System.Drawing.Color.White;
            this.buttonKargoSil.Location = new System.Drawing.Point(546, 98);
            this.buttonKargoSil.Name = "buttonKargoSil";
            this.buttonKargoSil.Size = new System.Drawing.Size(126, 33);
            this.buttonKargoSil.TabIndex = 29;
            this.buttonKargoSil.Text = "Kargo Sil";
            this.buttonKargoSil.UseVisualStyleBackColor = false;
            this.buttonKargoSil.Click += new System.EventHandler(this.buttonKargoSil_Click);
            // 
            // buttonKargoGuncelle
            // 
            this.buttonKargoGuncelle.BackColor = System.Drawing.Color.White;
            this.buttonKargoGuncelle.Location = new System.Drawing.Point(546, 139);
            this.buttonKargoGuncelle.Name = "buttonKargoGuncelle";
            this.buttonKargoGuncelle.Size = new System.Drawing.Size(126, 33);
            this.buttonKargoGuncelle.TabIndex = 30;
            this.buttonKargoGuncelle.Text = "Kargo Güncelle";
            this.buttonKargoGuncelle.UseVisualStyleBackColor = false;
            this.buttonKargoGuncelle.Click += new System.EventHandler(this.buttonKargoGuncelle_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(874, 489);
            this.Controls.Add(this.buttonKargoGuncelle);
            this.Controls.Add(this.buttonKargoSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSahibi);
            this.Controls.Add(this.groupBoxBilgiler);
            this.Controls.Add(this.buttonKargolariGetir);
            this.Controls.Add(this.buttonKargoEkle);
            this.Controls.Add(this.checkBoxTiklama);
            this.Controls.Add(this.adresText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.groupBoxBilgiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTiklama;
        private System.Windows.Forms.RichTextBox adresText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonKargoEkle;
        private System.Windows.Forms.Button buttonKargolariGetir;
        private System.Windows.Forms.GroupBox groupBoxBilgiler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSahibi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKargoSil;
        private System.Windows.Forms.Button buttonKargoGuncelle;
    }
}