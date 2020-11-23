using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevBase.Web.Models
{
    public class CategoryEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen kategori adını giriniz")]
        public string Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Lütfen bir ürün seçiniz")]
        public int ProductId { get; set; }
    }
}
