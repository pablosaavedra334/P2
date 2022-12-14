using P2s.Data.Entidad;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace P2s.Data.Entity
{
    public class City : IEntity
    {

        public int Id { set; get; }

        [Display(Name = "City")]
        public string Name { set; get; } = null!;

        [Display(Name = "Activo")]
        public bool IsActive { set; get; }
    }
}
