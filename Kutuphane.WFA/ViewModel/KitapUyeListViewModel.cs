using System;

namespace Kutuphane.WFA
{
    public class KitapUyeListViewModel
    {
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public string Barkod { get; set; }
        public string TCKN { get; set; }
        public string Kitap{ get; set; }
        public string Uye { get; set; }
        public DateTime KiralamaTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public decimal? Ceza { get; set; }
    }
}