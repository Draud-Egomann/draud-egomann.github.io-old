namespace Web.Models;

public class TimelineItem {
  public DateTime StartYear { get; set; }
  public DateTime EndYear { get; set; }
  public string Title { get; set; } = default!;
  public string Description { get; set; } = default!;
  public List<string> Classes { get; set; } = [];
}
