using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab.Components.Models
{
    public class Puesto
    {
        [Key]
        public int NroPuesto { get; set; }
        public bool Estado { get; set; }
        public int TramiteActual { get; set; }


        public void TerminarTramite (int NroTramite) { }
        public void SiguienteTramite(int NroTramite) { }

    }
}
