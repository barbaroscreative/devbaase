using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevBase.Web.Models
{
    public class ProductAddViewModel
    {
     
        [Display(Name="Marka")]
        [Required(ErrorMessage ="Marka Adı Boş Geçilemez")]
        public string Brand { get; set; }
        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage = "Ürün Adı Boş Geçilemez")]
        public string Name { get; set; }
        [Display(Name = "Ürün Bilgisi")]
        [Required(ErrorMessage = "Ürün Bilgisi Boş Geçilemez")]
        public string Description { get; set; }
    }
}
