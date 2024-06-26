namespace Web.Models;

public class FlipCardItem {
  public string FrontText { get; set; } = default!;
  public string BgImage { get; set; } = default!;
  public string? BackText { get; set; } = null;
}
