namespace Kutuphane.WFA
{
    partial class FrmKitap
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.panelYazarBilgisi = new System.Windows.Forms.Panel();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbYazarlar = new System.Windows.Forms.ComboBox();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.panelYazarBilgisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(692, 64);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 24);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(602, 64);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 24);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(602, 28);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(173, 23);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(92, 11);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(163, 20);
            this.txtKitapAdi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yazarlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kitap Adı:";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(92, 109);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(61, 20);
            this.nudAdet.TabIndex = 20;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(24, 168);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(751, 324);
            this.dgvKitaplar.TabIndex = 21;
            this.dgvKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellClick);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(357, 64);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(88, 23);
            this.btnYazarEkle.TabIndex = 18;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // panelYazarBilgisi
            // 
            this.panelYazarBilgisi.Controls.Add(this.txtYazarAdi);
            this.panelYazarBilgisi.Controls.Add(this.label4);
            this.panelYazarBilgisi.Location = new System.Drawing.Point(299, 92);
            this.panelYazarBilgisi.Margin = new System.Windows.Forms.Padding(0);
            this.panelYazarBilgisi.Name = "panelYazarBilgisi";
            this.panelYazarBilgisi.Size = new System.Drawing.Size(263, 58);
            this.panelYazarBilgisi.TabIndex = 22;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(78, 17);
            this.txtYazarAdi.Margin = new System.Windows.Forms.Padding(0);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(161, 20);
            this.txtYazarAdi.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yazar Adı:";
            // 
            // cmbYazarlar
            // 
            this.cmbYazarlar.FormattingEnabled = true;
            this.cmbYazarlar.Location = new System.Drawing.Point(377, 5);
            this.cmbYazarlar.Name = "cmbYazarlar";
            this.cmbYazarlar.Size = new System.Drawing.Size(163, 21);
            this.cmbYazarlar.TabIndex = 23;
            this.cmbYazarlar.SelectedIndexChanged += new System.EventHandler(this.cmbYazarlar_SelectedIndexChanged);
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.Location = new System.Drawing.Point(463, 64);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(88, 23);
            this.btnYazarGuncelle.TabIndex = 18;
            this.btnYazarGuncelle.Text = "Yazar Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(92, 60);
            this.txtBarkod.MaxLength = 5;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(163, 20);
            this.txtBarkod.TabIndex = 12;
            // 
            // FrmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.cmbYazarlar);
            this.Controls.Add(this.panelYazarBilgisi);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYazarGuncelle);
            this.Controls.Add(this.btnYazarEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKitap";
            this.Text = "FrmKitap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.panelYazarBilgisi.ResumeLayout(false);
            this.panelYazarBilgisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.Panel panelYazarBilgisi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYazarlar;
        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.TextBox txtBarkod;
    }
}