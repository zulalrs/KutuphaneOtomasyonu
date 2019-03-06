using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.WFA.Entities
{
    [Table("KitapUyeler")]
    public class KitapUye
    {

        [Key]
        [Column(Order =1)]
        public int KitapId { get; set; }
        [Key]
        [Column(Order =2)]
        public int UyeId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime KiralamaTarihi { get; set; } 

        [Column(TypeName = "smalldatetime")]
        public DateTime? TeslimTarihi { get; set; }

        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public decimal? Ceza { get; set; }

        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }
        [ForeignKey("UyeId")]
        public virtual Uye Uye { get; set; }
    }
}
