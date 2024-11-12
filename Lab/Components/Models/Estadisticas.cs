using System.ComponentModel.DataAnnotations;

namespace Lab.Components.Models
{
    public class Estadisticas
    {
        
        public List<Tramite> HistorialTramites {get; set;}

        public void TiempoDemoraProm(int idTramite) { }
        public void ClientesPorPeriodo(DateTime fechainicio, DateTime fechafin, int idOficina) { }



    }
}
