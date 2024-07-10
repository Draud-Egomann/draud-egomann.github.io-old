namespace Web.Models;

public class HorizontalGalleryImage : ImageItem {
  public int Id { get; set; }
  public string Position { get; set; } = default!;
  public double TranslateX { get; set; }
}
