using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;  // Necesario para [ForeignKey]

namespace Lab.Components.Models
{
    public class Tramite
    {
        [Key]
        public int NroTramite { get; set; }
        public int CedulaCliente { get; set; }
        [ForeignKey("Puesto")]
        public String NroPuesto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}