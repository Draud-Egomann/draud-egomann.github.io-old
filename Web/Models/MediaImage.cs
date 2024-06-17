namespace Web.Models;

public class MediaImage
{
  public string ImageUrl { get; set; } = default!;
  public string AltText { get; set; } = string.Empty;
  public string Text { get; set; } = string.Empty;
  public bool IsOverlayVisible { get; set; } = false;
}
