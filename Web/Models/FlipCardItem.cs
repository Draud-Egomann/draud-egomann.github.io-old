namespace Web.Models;

public class FlipCardItem : ImageBaseItem {
  public string FrontText { get; set; } = default!;
  public string? BackText { get; set; } = null;
}
