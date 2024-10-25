using System.ComponentModel.DataAnnotations;
using BackendBiblioteca.Enums;

namespace BackendBiblioteca.Models
{
    public class Book 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        
    }
}