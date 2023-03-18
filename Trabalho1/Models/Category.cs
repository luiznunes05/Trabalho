using System.ComponentModel.DataAnnotations;

namespace Trabalho1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é de Preenchimento obrigatorio!" )]
        public string Name { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;
        
        public int ZipCode { get; set; }

        public int Phone { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        public string Obs { get; set; } = null!;

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;  

    }
}
