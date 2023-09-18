using System.ComponentModel.DataAnnotations;

namespace ProjCp1.Models
{
    public class Roupas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Tecido { get; set; }

    }
}
