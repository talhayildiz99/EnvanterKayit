﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnvanterKayit.Entities
{
    public class Ogretmen : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Cihaz")]
        public int CihazId { get; set; }
        [StringLength(50), Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50)]
        [Display(Name = "Soyadı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }
        [StringLength(11)]
        [Display(Name = "TC Numarası")]
        public string? TcNo { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        [StringLength(500)]
        public string? Adres { get; set; }
        [StringLength(15)]
        public string? Telefon { get; set; }
        public string? Notlar { get; set; }
        public virtual Cihaz? Cihaz{ get; set; }
    }
}
