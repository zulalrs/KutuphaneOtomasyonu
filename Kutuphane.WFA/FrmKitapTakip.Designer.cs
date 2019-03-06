namespace Kutuphane.WFA
{
    partial class FrmKitapTakip
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
            this.grpUye = new System.Windows.Forms.GroupBox();
            this.txtUyeAra = new System.Windows.Forms.TextBox();
            this.grpKitap = new System.Windows.Forms.GroupBox();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.grpKitapIslemleri = new System.Windows.Forms.GroupBox();
            this.rbtnKirala = new System.Windows.Forms.RadioButton();
            this.rbtnTeslim = new System.Windows.Forms.RadioButton();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKitapUyeler = new System.Windows.Forms.DataGridView();
            this.chbUyeGecmisi = new System.Windows.Forms.CheckBox();
            this.grpUye.SuspendLayout();
            this.grpKitap.SuspendLayout();
            this.grpKitapIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapUyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUye
            // 
            this.grpUye.Controls.Add(this.txtUyeAra);
            this.grpUye.Location = new System.Drawing.Point(12, 28);
            this.grpUye.Name = "grpUye";
            this.grpUye.Size = new System.Drawing.Size(220, 59);
            this.grpUye.TabIndex = 0;
            this.grpUye.TabStop = false;
            this.grpUye.Text = "Üye Ara";
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.Location = new System.Drawing.Point(20, 25);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(183, 20);
            this.txtUyeAra.TabIndex = 2;
            this.txtUyeAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUyeAra_KeyUp);
            // 
            // grpKitap
            // 
            this.grpKitap.Controls.Add(this.txtKitapAra);
            this.grpKitap.Location = new System.Drawing.Point(12, 93);
            this.grpKitap.Name = "grpKitap";
            this.grpKitap.Size = new System.Drawing.Size(220, 59);
            this.grpKitap.TabIndex = 0;
            this.grpKitap.TabStop = false;
            this.grpKitap.Text = "Kitap Ara";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(20, 27);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(183, 20);
            this.txtKitapAra.TabIndex = 2;
            this.txtKitapAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKitapAra_KeyUp);
            // 
            // grpKitapIslemleri
            // 
            this.grpKitapIslemleri.Controls.Add(this.rbtnKirala);
            this.grpKitapIslemleri.Controls.Add(this.rbtnTeslim);
            this.grpKitapIslemleri.Controls.Add(this.btnOnayla);
            this.grpKitapIslemleri.Controls.Add(this.txtBarkod);
            this.grpKitapIslemleri.Controls.Add(this.label4);
            this.grpKitapIslemleri.Controls.Add(this.txtTckn);
            this.grpKitapIslemleri.Controls.Add(this.label3);
            this.grpKitapIslemleri.Location = new System.Drawing.Point(248, 28);
            this.grpKitapIslemleri.Name = "grpKitapIslemleri";
            this.grpKitapIslemleri.Size = new System.Drawing.Size(283, 124);
            this.grpKitapIslemleri.TabIndex = 0;
            this.grpKitapIslemleri.TabStop = false;
            this.grpKitapIslemleri.Text = "Kitap İşlemleri";
            // 
            // rbtnKirala
            // 
            this.rbtnKirala.AutoSize = true;
            this.rbtnKirala.Location = new System.Drawing.Point(138, 95);
            this.rbtnKirala.Name = "rbtnKirala";
            this.rbtnKirala.Size = new System.Drawing.Size(51, 17);
            this.rbtnKirala.TabIndex = 3;
            this.rbtnKirala.TabStop = true;
            this.rbtnKirala.Text = "Kirala";
            this.rbtnKirala.UseVisualStyleBackColor = true;
            // 
            // rbtnTeslim
            // 
            this.rbtnTeslim.AutoSize = true;
            this.rbtnTeslim.Location = new System.Drawing.Point(47, 93);
            this.rbtnTeslim.Name = "rbtnTeslim";
            this.rbtnTeslim.Size = new System.Drawing.Size(67, 17);
            this.rbtnTeslim.TabIndex = 3;
            this.rbtnTeslim.TabStop = true;
            this.rbtnTeslim.Text = "Teslim Al";
            this.rbtnTeslim.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(200, 25);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(70, 60);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(47, 65);
            this.txtBarkod.MaxLength = 5;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(142, 20);
            this.txtBarkod.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Barkod:";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(47, 27);
            this.txtTckn.MaxLength = 11;
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(142, 20);
            this.txtTckn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TCKN:";
            // 
            // dgvKitapUyeler
            // 
            this.dgvKitapUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapUyeler.Location = new System.Drawing.Point(5, 166);
            this.dgvKitapUyeler.Name = "dgvKitapUyeler";
            this.dgvKitapUyeler.ReadOnly = true;
            this.dgvKitapUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitapUyeler.Size = new System.Drawing.Size(783, 272);
            this.dgvKitapUyeler.TabIndex = 1;
            this.dgvKitapUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitapUyeler_CellClick);
            // 
            // chbUyeGecmisi
            // 
            this.chbUyeGecmisi.AutoSize = true;
            this.chbUyeGecmisi.Location = new System.Drawing.Point(572, 53);
            this.chbUyeGecmisi.Name = "chbUyeGecmisi";
            this.chbUyeGecmisi.Size = new System.Drawing.Size(112, 17);
            this.chbUyeGecmisi.TabIndex = 2;
            this.chbUyeGecmisi.Text = "Üye Kitap Geçmişi";
            this.chbUyeGecmisi.UseVisualStyleBackColor = true;
            this.chbUyeGecmisi.CheckedChanged += new System.EventHandler(this.chbUyeGecmisi_CheckedChanged);
            // 
            // FrmKitapTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.chbUyeGecmisi);
            this.Controls.Add(this.dgvKitapUyeler);
            this.Controls.Add(this.grpKitap);
            this.Controls.Add(this.grpKitapIslemleri);
            this.Controls.Add(this.grpUye);
            this.Name = "FrmKitapTakip";
            this.Text = "FrmKitapTakip";
            this.Load += new System.EventHandler(this.FrmKitapTakip_Load);
            this.grpUye.ResumeLayout(false);
            this.grpUye.PerformLayout();
            this.grpKitap.ResumeLayout(false);
            this.grpKitap.PerformLayout();
            this.grpKitapIslemleri.ResumeLayout(false);
            this.grpKitapIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapUyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUye;
        private System.Windows.Forms.TextBox txtUyeAra;
        private System.Windows.Forms.GroupBox grpKitap;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.GroupBox grpKitapIslemleri;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnKirala;
        private System.Windows.Forms.RadioButton rbtnTeslim;
        private System.Windows.Forms.DataGridView dgvKitapUyeler;
        private System.Windows.Forms.CheckBox chbUyeGecmisi;
    }
}