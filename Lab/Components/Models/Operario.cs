using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab.Components.Models
{
    public class Operarios : Usuario
    {
        [Required]
        public int NumeroOperario { get; set; }
        public int PuestoAsignado { get; set; }

        public void AtenderCliente() { }
        public override string GetRole()
        {
            return "Operario";
        }
    }
}
