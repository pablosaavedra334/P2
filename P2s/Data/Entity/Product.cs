using P2s.Data.Entidad;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace P2s.Data.Entity
{
    public class Product:IEntity
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido...") ]
        [Display(Name = "Producto")]
        [MaxLength(150,ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]

        public string Name { get; set; } = null!;


        [Display(Name = "Precio")]

        [DisplayFormat(DataFormatString ="(0:C2)", ApplyFormatInEditMode =false) ]
        public decimal Price { get; set; }


        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; } = null!;
       
        public DateTime? LastPurchase { get; set; }
     
        public DateTime? LastSale { get; set; }

        [Display(Name = "Activo")]
        [Required]
        public bool IsActive { set; get; }

        [Display(Name = "Stock en almacenes")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        [DisplayFormat(DataFormatString = "(0:C2)", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public Usser User { set; get; }
    }
}
