using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.WFA.Business
{
    public class KiralamaBusiness
    {
        public static DateTime KiralamaTarihi()
        {
            Random rnd = new Random();
            DateTime tarih = new DateTime(DateTime.Today.Year, 1, 1);
            int fark = (DateTime.Today - tarih).Days;
            return tarih.AddDays(rnd.Next(fark));
        }
        public static DateTime TeslimTarih(DateTime kiralamaTarihi)
        {
            Random rnd = new Random();
            DateTime tarih = kiralamaTarihi;
            return tarih.AddDays(rnd.Next(60));
        }
        public static List<KitapUyeListViewModel> Ara(List<KitapUyeListViewModel> datasource, string param) 
        {

            param = param.ToLower();
            MyContext db = new MyContext();          

            db.KitapUyeler
                .Where(x => x.Uye.TCKN.ToLower().Contains(param)
                          || x.Uye.Ad.ToLower().Contains(param) || x.Uye.Soyad.ToLower().Contains(param) || x.Kitap.Barkod.ToLower().Contains(param) || x.Kitap.KitapAdi.ToLower().Contains(param))
                .ToList()
                .ForEach(x => datasource.Add(new KitapUyeListViewModel()
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

                }));
            return datasource;
        }
    }
}
