using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Components.Models
{
    public class Monitor
    {
        [Key]
        public int idMonitor { get; set; }
        public List<Tramite> TramitesActivos { get; set; }

        // Clave foránea a Oficina
        [ForeignKey("Oficina")]
        public int idOficina { get; set; }

        public void MostrarInfo() { }
    }
}
