using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;


namespace CO550_Project_Blazor.Models
{
    public class Film
    {
        [Key]
        public int FilmID { get; set; } = 0;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string ReleaseDate { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Runtime { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string? ImageURL { get; set; }

    }
}
