namespace Web.Models;

public class MediaItem : Image {
  public string? Title { get; set; }
  public string? Description { get; set; }
  public bool HasLink => !string.IsNullOrWhiteSpace(LinkUrl);
  public string? LinkUrl { get; set; }
}
