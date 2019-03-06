using Kutuphane.WFA.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public FrmUye frmUye;
        public FrmKitap frmKitap;
        public FrmKitapTakip frmKitapTakip;
        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUye == null || frmUye.IsDisposed)
            {
                frmUye = new FrmUye();
                frmUye.MdiParent = this;
                frmUye.Show();
            }
            frmUye.Activate();
        }
        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKitap == null || frmKitap.IsDisposed)
            {
                frmKitap = new FrmKitap();
                frmKitap.MdiParent = this;
                frmKitap.Show();
            }
            frmKitap.Activate();
        }
        private void kitapTakipİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKitapTakip == null || frmKitapTakip.IsDisposed)
            {
                frmKitapTakip = new FrmKitapTakip();
                frmKitapTakip.MdiParent = this;
                frmKitapTakip.Show();
            }
            frmKitapTakip.Activate();
        }

        private void içeAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dışaAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
