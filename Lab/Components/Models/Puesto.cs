using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Components.Models
{
    public class Puesto
    {
        [Key]
        public int NroPuesto { get; set; }

        public bool Estado { get; set; }
        public int TramiteActual { get; set; }

        // Clave foránea a Oficina
        [ForeignKey("Oficina")]
        public int idOficina { get; set; }

        // Propiedad de navegación
        public Oficina Oficina { get; set; }

        public void TerminarTramite(int NroTramite) { }
        public void SiguienteTramite(int NroTramite) { }
    }
}
