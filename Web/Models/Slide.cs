namespace Web.Models;

public class Slide {
  public string ImageUrl { get; set; } = default!;
  public string AltText { get; set; } = string.Empty;
  public string Thumbnail { get; set; } = default!;
  public string? Caption { get; set; }
}