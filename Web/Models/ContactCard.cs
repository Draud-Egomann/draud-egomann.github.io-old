namespace Web.Models;

public class ContactCard {
  public string ImageUrl { get; set; } = default!;
  public string AltText { get; set; } = default!;
  public string Text { get; set; } = default!;
  public bool IsLink { get; set; } = false;
  public string? LinkUrl { get; set; }
}
