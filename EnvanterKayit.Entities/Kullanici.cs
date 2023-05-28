using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnvanterKayit.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        public int RolId { get; set; }

        [StringLength(50), Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50), Display(Name = "Soyadı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        [StringLength(20)]
        public string? Telefon { get; set; }
        [StringLength(50), Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [StringLength(50), Display(Name = "Şifre"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        [Display(Name = "Rol")]
        public virtual Rol? Rol { get; set; }
    }
}
