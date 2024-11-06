using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab.Components.Models
{
    public class Oficina
    {
        [Key]
        public int idOficina { get; set; }
        public List<Puesto>? ListaPuestos { get; set; } = new List<Puesto>();

        public String Nombre { get; set; }
        public String Ubicacion { get; set; }
        public void ObtenerEstadisticas() { }

        public void ActualizarMonitores(int nroTramite) { }
    }
}
