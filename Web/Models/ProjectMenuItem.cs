namespace Web.Models;

public class ProjectMenuItem {
  public string Title { get; set; } = default!;
  public string Description { get; set; } = default!;
  public bool HasMoreInfo { get; set; } = default!;
  public string? MoreInfoText { get; set; }
  public List<string> Classes { get; set; } = [];
}
