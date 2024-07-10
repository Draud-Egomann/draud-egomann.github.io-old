namespace Web.Models;

public class ImageReference {
  public string ImageUrl { get; set; }
  public string AltText { get; set; } = string.Empty;
  public string? ProfileName { get; set; }
  public string? ProfileUrl { get; set; }
  public string SiteName { get; set; }
  public string SiteUrl { get; set; }
}
