namespace Lab.Components.Models
    
{
    public class Operario : Usuario
    {
        public int NumeroOperario { get; set; }
        public int PuestoAsignado { get; set; }

        public void AtenderCliente() { }
        public override string GetRole()
        {
            return "Operario";
        }
    }
    public class Administrador : Usuario
    {
        public void GestionarOficina() { }
        public void GestionarPuesto() { }

        public override string GetRole()
        {
            return "Admin";
        }

    }
    public class GerenteCalidad : Usuario
    {
        public void ObtenerEstadisticas() { }

        public override string GetRole()
        {
            return "GerenteCalidad";
        }
    }
   

}
