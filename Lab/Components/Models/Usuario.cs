using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Lab.Components.Models
{
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual string GetRole()
        {
            return "Usuario";
        }
    }
}



