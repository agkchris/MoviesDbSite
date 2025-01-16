using System.ComponentModel.DataAnnotations;

namespace MoviesDbSite.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    [Required]
    public int ReleaseYear { get; set; }

    [Required]
    [StringLength(100)]
    public string Director { get; set; } = string.Empty;

    [StringLength(200)]
    public string? Genre { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}