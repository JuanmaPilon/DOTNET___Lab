using System.ComponentModel.DataAnnotations;

namespace Lab.Components.Models
{
    public class Estadisticas
    {
        [Key]
        public int idEstadisticas { get; set; }
        public List<Tramite> HistorialTramites {get; set;}

        public void TiempoDemoraProm() { }
        public void ClientesPorPeriodo(DateTime fechaini, DateTime fechafin) { }
        public void CantidadDeClientes() { }



    }
}
