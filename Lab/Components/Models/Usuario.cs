namespace Lab.Components.Models
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual string GetRole()
        {
            return "Usuario";
        }
    }
}



