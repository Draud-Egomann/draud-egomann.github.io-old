namespace Web.Models;

public class FlipCardItem : ImageItem {
  public string FrontText { get; set; } = default!;
  public string? BackText { get; set; } = null;
}
