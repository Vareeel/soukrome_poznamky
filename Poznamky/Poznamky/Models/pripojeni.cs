using System.ComponentModel.DataAnnotations;

namespace Poznamky.Models
{
    public class pripojeni
    {
        [Key]
        public string? jmeno { get; set; }


        [Required]

        public string email { get; set; }

        [Required]

        public string heslo { get; set; }

    }
}

