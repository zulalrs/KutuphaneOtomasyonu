using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.WFA.Entities
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        [StringLength(5)]
        [Required]
        [Index(IsUnique = true)]
        public string Barkod { get; set; }

        [StringLength(50)]
        [Required]
        public string KitapAdi { get; set; }

        public int Adet { get; set; } = 0;

        [Required]
        public int YazarId { get; set; }

        [ForeignKey("YazarId")]
        public virtual Yazar Yazarlar { get; set; }

        public virtual ICollection<KitapUye> KitapUyeler { get; set; } = new HashSet<KitapUye>();

        public override string ToString()
        {
            return $"{KitapAdi}";
        }

    }
}
