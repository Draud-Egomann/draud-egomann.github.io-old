namespace Web.Models;

public class SourceCard {
  public string ImageUrl { get; set; }
  public string AltText { get; set; } = string.Empty;
  public string? ImageClass { get; set; }
  public string? Title { get; set; }
  public string Text { get; set; }
  public string? SourceUrl { get; set; }
}
