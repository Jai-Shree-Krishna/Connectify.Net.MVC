using MVC_1.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Comment
{
    [Key]
    public int Id { get; set; } // Assuming an integer ID, you can change this to match your database setup

    [Required]
    public int UserId { get; set; } // Foreign key to User

    [ForeignKey("UserId")]
    public User User { get; set; } // Navigation property for User

    [Required]
    public int PostId { get; set; } // Foreign key to Post

    [ForeignKey("PostId")]
    public Post Post { get; set; } // Navigation property for Post

    [Required]
    public string Description { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public int Likes { get; set; } = 0;

    public int Dislikes { get; set; } = 0;
}
