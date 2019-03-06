namespace Kutuphane.WFA
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışaAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTakipİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem,
            this.kitapTakipİşlemleriToolStripMenuItem,
            this.veriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            this.üyeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeİşlemleriToolStripMenuItem_Click);
            // 
            // veriToolStripMenuItem
            // 
            this.veriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeAktarToolStripMenuItem,
            this.dışaAktarToolStripMenuItem});
            this.veriToolStripMenuItem.Name = "veriToolStripMenuItem";
            this.veriToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.veriToolStripMenuItem.Text = "Veri";
            // 
            // içeAktarToolStripMenuItem
            // 
            this.içeAktarToolStripMenuItem.Name = "içeAktarToolStripMenuItem";
            this.içeAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.içeAktarToolStripMenuItem.Text = "İçe Aktar";
            this.içeAktarToolStripMenuItem.Click += new System.EventHandler(this.içeAktarToolStripMenuItem_Click);
            // 
            // dışaAktarToolStripMenuItem
            // 
            this.dışaAktarToolStripMenuItem.Name = "dışaAktarToolStripMenuItem";
            this.dışaAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dışaAktarToolStripMenuItem.Text = "Dışa Aktar";
            this.dışaAktarToolStripMenuItem.Click += new System.EventHandler(this.dışaAktarToolStripMenuItem_Click);
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            this.kitapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİşlemleriToolStripMenuItem_Click);
            // 
            // kitapTakipİşlemleriToolStripMenuItem
            // 
            this.kitapTakipİşlemleriToolStripMenuItem.Name = "kitapTakipİşlemleriToolStripMenuItem";
            this.kitapTakipİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.kitapTakipİşlemleriToolStripMenuItem.Text = "Kitap Takip İşlemleri";
            this.kitapTakipİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapTakipİşlemleriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 551);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışaAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTakipİşlemleriToolStripMenuItem;
    }
}

