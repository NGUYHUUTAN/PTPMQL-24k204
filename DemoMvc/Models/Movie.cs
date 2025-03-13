using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateTime Releasedate { get; set; }
    public decimal Price { get; set; }
}