using Lab.Components.Pages;
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
        public Oficina? Oficina { get; set; }

        public void TerminarTramite(Tramite tramite)
        {
            // Cambiar el estado del puesto
            TramiteActual = 0;
            Estado = false;

            // Asignar la fecha de finalización al trámite
            tramite.FechaFin = DateTime.Now;
        }
        public void SiguienteTramite(Tramite nuevoTramite)
        {
            // Asignar el nuevo número de trámite al puesto
            TramiteActual = nuevoTramite.NroTramite;

            // Reactivar el puesto
            Estado = true;
        }
    }
}
