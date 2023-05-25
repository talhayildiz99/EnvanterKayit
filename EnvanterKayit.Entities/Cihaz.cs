using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnvanterKayit.Entities
{
    public class Cihaz : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int MarkaId { get; set; }
        [Display(Name = "Cihaz Türü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int TurId { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Renk { get; set; }
       
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Modeli { get; set; }
        [Display(Name = "İşlemci"), StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")] 
        public string İslemcisi{ get; set; }
        [Display(Name = "Ekran Kartı"), StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string EkranKartı { get; set; }
        [Display(Name = "Seri No"), StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string SeriNo{ get; set; }
       
        [Display(Name = "Model Yılı")]
        public int ModelYili { get; set; }
        [Display(Name = "Satışta Mı?")]
        public bool SatistaMi { get; set; }
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Notlar { get; set; }
        public virtual Marka? Marka { get; set; }
        public virtual Tur? Tur { get; set; }
    }
}
