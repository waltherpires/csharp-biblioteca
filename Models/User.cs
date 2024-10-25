using System.ComponentModel.DataAnnotations;

namespace BackendBiblioteca.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        [Range(8,12, ErrorMessage="Invalid size for phone")]
        public string Phone { get; set; }

    }
}