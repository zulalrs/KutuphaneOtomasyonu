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
    public partial class FrmKitap : Form
    {
        public FrmKitap()
        {
            InitializeComponent();
        }

        private void FrmKitap_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            VerileriGetir();
        }

        public void VerileriGetir()
        {
            MyContext db = new MyContext();
            var kitaplar = db.Kitaplar
                 .OrderBy(x => x.KitapId)
                 .Select(x => new KitapListeViewModel
                 {
                     KitapId = x.KitapId,
                     KitapAdi = x.KitapAdi,
                     Barkod = x.Barkod,
                     Adet = x.Adet,
                     YazarId = x.YazarId,
                     Yazar = x.Yazarlar.YazarAdi
                 })
                 .ToList();
            dgvKitaplar.DataSource = kitaplar;

            var yazarlar = db.Yazarlar
                .OrderBy(x => x.YazarAdi)                
                .Select(x => new YazarListeViewModel
                {
                    YazarId = x.YazarId,
                    YazarAdi=x.YazarAdi
                })
                .ToList();
            cmbYazarlar.DataSource = yazarlar;

        }
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                db.Yazarlar.Add(new Yazar()
                {
                   YazarAdi=txtYazarAdi.Text
                });
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayıt eklendi");
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            txtYazarAdi.Text = txtYazarAdi.Text ?? (txtYazarAdi.Text = "");           
            try
            {
                MyContext db = new MyContext();
                db.Kitaplar.Add(new Kitap()
                {
                    KitapAdi = txtKitapAdi.Text,
                    Barkod = txtBarkod.Text,
                    Adet = Convert.ToInt16(nudAdet.Value),
                    YazarId = (cmbYazarlar.SelectedItem as YazarListeViewModel).YazarId,
                });
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayıt eklendi");
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        KitapListeViewModel secili;
        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKitaplar.CurrentRow.Index != -1)
            {
                secili = dgvKitaplar.CurrentRow.DataBoundItem as KitapListeViewModel;
                MyContext db = new MyContext();
                var kitap = db.Kitaplar.Find(secili.KitapId);
                txtBarkod.Text = kitap.Barkod;
                txtKitapAdi.Text = kitap.KitapAdi;
                nudAdet.Value = kitap.Adet;

                var yazarlistesi = cmbYazarlar.DataSource as List<YazarListeViewModel>;
                foreach (var item in yazarlistesi)
                {
                    if (item.YazarId == kitap.YazarId)
                    {
                        cmbYazarlar.SelectedItem = item;
                    }
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                secili = dgvKitaplar.CurrentRow.DataBoundItem as KitapListeViewModel;
                var kitap = db.Kitaplar.Find(secili.KitapId);
                kitap.KitapId = (dgvKitaplar.CurrentRow.DataBoundItem as KitapListeViewModel).KitapId;
                kitap.KitapAdi = txtKitapAdi.Text;
                kitap.Barkod = txtBarkod.Text;
                kitap.Adet = Convert.ToInt16(nudAdet.Value);
                kitap.YazarId = (cmbYazarlar.SelectedItem as YazarListeViewModel).YazarId;

                int sonuc = db.SaveChanges();
                VerileriGetir();
                MessageBox.Show($"{sonuc} urun guncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow.Index != -1)
            {
                secili = dgvKitaplar.CurrentRow.DataBoundItem as KitapListeViewModel;
                var cevap = MessageBox.Show("Secili urunu silmek istiyor musunuz?", "Urun silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap != DialogResult.Yes) return;
                try
                {
                    MyContext db = new MyContext();
                    var kitap = db.Kitaplar.Find(secili.KitapId);
                    db.Kitaplar.Remove(kitap);
                    MessageBox.Show($"{db.SaveChanges()} kayıt silindi");
                    VerileriGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYazarAdi.Text = (cmbYazarlar.SelectedItem as YazarListeViewModel).YazarAdi;          
        }
        YazarListeViewModel seciliYazar;
        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            seciliYazar = cmbYazarlar.SelectedItem as YazarListeViewModel;
            var yazar = db.Yazarlar.Find(seciliYazar.YazarId);
            yazar.YazarAdi = txtYazarAdi.Text;

            int sonuc = db.SaveChanges();
            VerileriGetir();
            MessageBox.Show($"{sonuc} yazar guncellendi");
        }
    }
}
