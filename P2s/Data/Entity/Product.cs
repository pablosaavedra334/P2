using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace P2s.Data.Entity
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Producto")]
        
        public string Name { get; set; } = null!;


        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString ="(0:C2)", ApplyFormatInEditMode =false) ]
        public decimal Price { get; set; }


        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; } = null!;
       
        public DateTime LastPurchase { get; set; }
     
        public DateTime LastSale { get; set; }

        [Display(Name = "Activo")]
        [Required]
        public bool IsActive { set; get; }

        [Display(Name = "Stock en almacenes")]
        [Required]
        [DisplayFormat(DataFormatString = "(0:C2)", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
    }
}
