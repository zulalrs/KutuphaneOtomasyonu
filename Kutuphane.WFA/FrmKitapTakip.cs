using Kutuphane.WFA.Business;
using Kutuphane.WFA.Entities;
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
    public partial class FrmKitapTakip : Form
    {
        public FrmKitapTakip()
        {
            InitializeComponent();
        }
        private void FrmKitapTakip_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            MyContext db = new MyContext();
            var kitapUyeler = db.KitapUyeler
                .Select(x => new KitapUyeListViewModel
                {
                    KitapId = x.KitapId,
                    UyeId = x.UyeId,
                    Barkod = x.Kitap.Barkod,
                    Kitap = x.Kitap.KitapAdi,
                    TCKN = x.Uye.TCKN,
                    Uye = x.Uye.Ad + " " + x.Uye.Soyad,
                    KiralamaTarihi = x.KiralamaTarihi,
                    TeslimTarihi = x.TeslimTarihi,
                    Ceza = x.Ceza
                })
                .ToList();
            dgvKitapUyeler.DataSource = kitapUyeler;
        }

        DateTime kiralamaTarihi;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            var kitap = db.Kitaplar.FirstOrDefault(x => x.Barkod == txtBarkod.Text);
            var uye = db.Uyeler.FirstOrDefault(x => x.TCKN == txtTckn.Text);

            if (rbtnKirala.Checked)
            {
                kiralamaTarihi = KiralamaBusiness.KiralamaTarihi();

                foreach (var item in db.Kitaplar)
                {
                    if (kitap.KitapId == item.KitapId)
                    {
                        if (item.Adet > 0)
                        {
                            var kitapUyeler = db.KitapUyeler.Add(new KitapUye()
                            {
                                KiralamaTarihi = kiralamaTarihi,
                                KitapId = kitap.KitapId,
                                UyeId = uye.UyeId
                            });
                            item.Adet--;
                        }
                        else { MessageBox.Show("Bu kitaptan rafta yok"); }

                    }

                }
            }

            else if (rbtnTeslim.Checked)
            {
                foreach (var item in db.KitapUyeler)
                {
                    if (uye.UyeId == item.UyeId && kitap.KitapId == item.KitapId && item.TeslimTarihi == null)
                    {
                        DateTime teslimTarihi = KiralamaBusiness.TeslimTarih(item.KiralamaTarihi);
                        item.TeslimTarihi = teslimTarihi;
                        int gun = (teslimTarihi - item.KiralamaTarihi).Days;
                        if (gun > 7) item.Ceza = gun * 5;
                        else item.Ceza = 0;
                        item.Kitap.Adet++;
                    }
                }

            }
            else
                return;
            int sonuc = db.SaveChanges();
            MessageBox.Show($"{sonuc} kayıt eklendi");
            VerileriGetir();
            var anaForm = this.MdiParent as Form1;
            anaForm.frmKitap?.VerileriGetir();

        }

        KitapUyeListViewModel secili;
        private void dgvKitapUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKitapUyeler.CurrentRow.Index != -1)
            {
                secili = dgvKitapUyeler.CurrentRow.DataBoundItem as KitapUyeListViewModel;
                MyContext db = new MyContext();
                var takip = db.KitapUyeler.First(x => x.KitapId == secili.KitapId && x.UyeId == secili.UyeId);
                txtBarkod.Text = takip.Kitap.Barkod;
                txtTckn.Text = takip.Uye.TCKN;
            }
        }

        private void txtUyeAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtUyeAra.Text.ToLower();

            MyContext db = new MyContext();
            List<KitapUyeListViewModel> bulunanlar = new List<KitapUyeListViewModel>();
            dgvKitapUyeler.DataSource = KiralamaBusiness.Ara(bulunanlar, ara);
        }

        private void txtKitapAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtKitapAra.Text.ToLower();

            MyContext db = new MyContext();
            List<KitapUyeListViewModel> bulunanlar = new List<KitapUyeListViewModel>();
            dgvKitapUyeler.DataSource = KiralamaBusiness.Ara(bulunanlar, ara);
        }

        private void chbUyeGecmisi_CheckedChanged(object sender, EventArgs e)
        {
            rbtnKirala.Enabled = false;
            rbtnTeslim.Enabled = false;
            btnOnayla.Enabled = false;
          
            if (chbUyeGecmisi.Checked)
            {              
                MyContext db = new MyContext();
                var uye = db.Uyeler.FirstOrDefault(x => x.TCKN == txtTckn.Text);

                var uyegecmisi = from u in db.Uyeler
                                 join kitapuye in db.KitapUyeler on u.UyeId equals kitapuye.UyeId
                                 join kitap in db.Kitaplar on kitapuye.KitapId equals kitap.KitapId
                                 where u.UyeId == uye.UyeId
                                 select new
                                 {
                                     u.TCKN,
                                     u.Ad,
                                     u.Soyad,
                                     kitap.KitapAdi,
                                     kitapuye.KiralamaTarihi,
                                     kitapuye.TeslimTarihi,
                                     kitapuye.Ceza
                                 };

                dgvKitapUyeler.DataSource = uyegecmisi.ToList();
            }
            else
            {
                VerileriGetir();
            }
        }
    }
}

