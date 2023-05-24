using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnvanterKayit.Entities
{
    public class Servis : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Servise Geliş Tarihi")]
        public DateTime ServisAcilisTarihi { get; set; }
        [Display(Name = "Cihaz Sorunu"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string CihazSorunu { get; set; }
        [Display(Name = "Servis Ücreti")]
        public decimal ServisUcreti { get; set; }
        [Display(Name = "Servisten Çıkış Tarihi")]
        public DateTime ServistenCikisTarihi { get; set; }
        [Display(Name = "Yapılan İşlemler")]
        public string? Yapılanİslemler { get; set; }
        [Display(Name = "Garanti Kapsamında Mı ?")]
        public bool GarantiKapsamindaMi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Cihaz { get; set; }
        [StringLength(15)]
        [Display(Name = "Seri No"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string SeriNo { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Notlar { get; set; }
    }
}
