using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.WFA.Entities
{
    [Table("Uyeler")]
    public class Uye
    {
        [Key]
        public int UyeId { get; set; }

        [StringLength(20)]
        [Required]
        public string Ad { get; set; }

        [StringLength(20)]
        [Required]
        public string Soyad { get; set; }

        [StringLength(11)]
        [Required]
        [Index(IsUnique =true)]
        public string TCKN { get; set; }

        [StringLength(10,ErrorMessage ="Telefon numaranızı başında sıfır olmadan yazınız.")]
        [Required]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DogumTarihi { get; set; }

        public virtual ICollection<KitapUye> KitapUyeler { get; set; } = new HashSet<KitapUye>();

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
