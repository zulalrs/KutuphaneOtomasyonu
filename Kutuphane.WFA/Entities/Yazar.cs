using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.WFA.Entities
{
    [Table("Yazarlar")]
    public class Yazar
    {
        [Key]
        public int YazarId { get; set; }

        [StringLength(70)]
        [Required]
        public string YazarAdi { get; set; }   

        public virtual ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();


    }
}
