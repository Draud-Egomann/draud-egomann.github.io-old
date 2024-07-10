namespace Web.Models;

public class HorizontalGalleryItem : ImageItem {
  public int Id { get; set; }
  public string Position { get; set; } = default!;
  public double TranslateX { get; set; }
}
