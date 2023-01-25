using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Razor.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
