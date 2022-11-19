
using P2s.Data.Entidad;
using System.ComponentModel.DataAnnotations;

namespace P2s.Data.Entity
{
    public class Country :IEntity
    {

        public int Id { set; get; }

        [Display(Name = "Pais")]
        public string Name { set; get; } = null!;

        [Display(Name = "Activo")]
        public bool IsActive { set; get; }

    }
}
