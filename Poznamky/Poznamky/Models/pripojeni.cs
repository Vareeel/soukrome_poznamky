using System.ComponentModel.DataAnnotations;

namespace Poznamky.Models
{
    public class pripojeni
    {
        [Key]
        public string? jmeno_uzivatele { get; set; }


        [Required]

        public string email { get; set; }

        [Required]

        public string heslo { get; set; }

    }
}

