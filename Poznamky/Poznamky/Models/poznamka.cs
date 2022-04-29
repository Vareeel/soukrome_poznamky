using System.ComponentModel.DataAnnotations;

namespace Poznamky.Models
{
    public class poznamka
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nadpis { get; set; } = String.Empty;

        [Required]
        public string Text { get; set; } = String.Empty;

        [Required]
        public DateTime CasPridani { get; set; }

        [Required]
        public string jmeno{ get; set; }

    
        [Required]
        public bool dulezita_poznamka { get; set; }
    }
}
