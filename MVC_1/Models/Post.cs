using MVC_1.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC_1.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; } // Assuming an integer ID, you can change this to match your database setup

        [Required]
        public int UserId { get; set; } // Foreign key to User

        [ForeignKey("UserId")]
        public required User User { get; set; } // Navigation property for User

        [Required]
        public required string Title { get; set; }

        public required string Description { get; set; }

        [Required]
        public required string Image { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public int Likes { get; set; } = 0;

        public int Dislikes { get; set; } = 0;
    }
}



