namespace Web.Models;

public class Image {
  public string ImageUrl { get; set; } = default!;
  public string? ImageClass { get; set; }
  public string? AltText { get; set; }
}
