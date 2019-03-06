
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
    public partial class FrmUye : Form
    {
        public FrmUye()
        {
            InitializeComponent();
        }
     
        private void FrmUye_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            VerileriGetir();

        }
        public void VerileriGetir()
        {
            MyContext db = new MyContext();
            var uyeler = db.Uyeler
                .OrderBy(x => x.UyeId)
                .Select(x => new UyeListeViewModel
                {
                    UyeId = x.UyeId,
                    TCKN = x.TCKN,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    Telefon = x.Telefon,
                    Mail = x.Mail,
                    DogumTarihi = x.DogumTarihi
                })
                .ToList();
            dgvUyeler.DataSource = uyeler;
           

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                MyContext db = new MyContext();
                db.Uyeler.Add( new Uye()
                {
                    TCKN = txtTckn.Text,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Mail = txtMail.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
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
        UyeListeViewModel secili;
        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUyeler.CurrentRow.Index != -1)
            {
                secili = dgvUyeler.CurrentRow.DataBoundItem as UyeListeViewModel;
                MyContext db = new MyContext();
                var uye = db.Uyeler.Find(secili.UyeId);
                txtTckn.Text = uye.TCKN;
                txtAd.Text = uye.Ad;
                txtSoyad.Text = uye.Soyad;
                txtTelefon.Text = uye.Telefon;
                txtMail.Text = uye.Mail;
                dtpDogumTarihi.Value = uye.DogumTarihi;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                secili = dgvUyeler.CurrentRow.DataBoundItem as UyeListeViewModel;
                var uye = db.Uyeler.Find(secili.UyeId);
                uye.UyeId = (dgvUyeler.CurrentRow.DataBoundItem as UyeListeViewModel).UyeId;
                uye.TCKN = txtTckn.Text;
                uye.Ad = txtAd.Text;
                uye.Soyad = txtSoyad.Text;
                uye.Telefon = txtTelefon.Text;
                uye.Mail = txtMail.Text;
                uye.DogumTarihi = dtpDogumTarihi.Value;
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
            if(dgvUyeler.CurrentRow.Index!=-1)
            {
                secili = dgvUyeler.CurrentRow.DataBoundItem as UyeListeViewModel;
                var cevap = MessageBox.Show("Secili urunu silmek istiyor musunuz?", "Urun silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap != DialogResult.Yes) return;
                try
                {
                    MyContext db = new MyContext();
                    var uye = db.Uyeler.Find(secili.UyeId);
                    db.Uyeler.Remove(uye);
                    MessageBox.Show($"{db.SaveChanges()} kayıt silindi");
                    VerileriGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       
    }
}
