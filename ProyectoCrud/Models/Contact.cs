using System.ComponentModel.DataAnnotations;

namespace ProyectoCrud.Models
{
    public class Contact
    {
        // [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El número de celular es obligatorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
