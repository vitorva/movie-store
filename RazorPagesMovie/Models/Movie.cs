using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Movie
{
    private DateTime releaseDate;

    public Movie()
    {
        releaseDate = DateTime.UtcNow;
    }
    

    // https://stackoverflow.com/questions/64676840/entity-framework-core-2-1-add-migration-system-nullreferenceexception-object-re

    public int Id { get; set; }
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate
    {
        get { return releaseDate; }
        set { releaseDate = DateTime.SpecifyKind(value, DateTimeKind.Utc); }
    }
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public string Rating { get; set; } = string.Empty;
}