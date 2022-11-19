using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace P2s.Data.Entity
{
    public class Usser : IdentityUser
    {
        [Display(Name = "Nombres")]
        [MaxLength(150, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        public string FirsName { set; get; }


        [Display(Name = "Apellido")]
        [MaxLength(150, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        public string Name { set; get; }


    }
}
