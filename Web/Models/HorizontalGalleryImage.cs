namespace Web.Models;

public class HorizontalGalleryImage
{
  public int Id { get; set; }
  public string ImageUrl { get; set; } = default!;
  public string AltText { get; set; } = string.Empty;
  public string Position { get; set; } = default!;
  public double TranslateX { get; set; }
}
