namespace Web.Models;

public class ImageItem {
  public string ImageUrl { get; set; } = default!;
  public string? ImageClass { get; set; }
  public string? AltText { get; set; }
  public string? ThumbnailUrl { get; set; }
  public string? ThumbnailAltText { get; set; }
}
