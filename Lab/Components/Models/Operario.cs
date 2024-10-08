namespace Lab.Components.Models
{
    public class Operario : Usuario
    {
        public int NumeroOperario { get; set; }
        public int PuestoAsignado { get; set; }

        public void AtenderCliente() { }

    }
}
