using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Components.Models
{
    public class Operario : Usuario
    {
        [Required]
        public int NumeroOperario { get; set; }
        [ForeignKey("Puesto")]
        public int? PuestoAsignadoId { get; set; }

        public void AtenderCliente() { }
        public override string GetRole()
        {
            return "Operario";
        }
    }
}
