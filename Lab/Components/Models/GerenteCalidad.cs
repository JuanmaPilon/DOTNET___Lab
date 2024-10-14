namespace Lab.Components.Models
{
    public class GerenteCalidad : Usuario
    {
        public void ObtenerEstadisticas() { }

        public override string GetRole()
        {
            return "GerenteCalidad";
        }
    }
}
