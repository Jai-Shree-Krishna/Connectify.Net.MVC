using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } // Assuming an integer ID, you can change this to match your database setup

        [System.ComponentModel.DataAnnotations.Required]
        public required string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public required string LastName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [Unique] // You might need to implement unique constraints based on your database
        public required string UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public required string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public required string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public required string Gender { get; set; }

        public DateTime Date { get; set; } = DateTime.Now; // Setting the default value

        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Dob { get; set; }

        public int Age { get; set; }

        public byte[] Image { get; set; }
    }
}