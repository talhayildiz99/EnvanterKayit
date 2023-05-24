using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnvanterKayit.Entities
{
    public class Satis : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Cihaz")]
        public int CihazId { get; set; }
        [Display(Name = "Satış Fiyatı")]
        public decimal SatisFiyati { get; set; }
        [Display(Name = "Satış Tarihi")]
        public DateTime SatisTarihi { get; set; }
        [Display(Name = "Cihaz")]
        public virtual Cihaz? Cihaz { get; set; }
        [Display(Name = "Müşteri")]
        public string? Notlar { get; set; }
    }
}
