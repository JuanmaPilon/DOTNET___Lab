namespace Lab.Components.Models
    
{
  
    public class Administrador : Usuario
    {
        public void GestionarOficina() { }
        public void GestionarPuesto() { }

        public override string GetRole()
        {
            return "Admin";
        }

    }
   
   

}
