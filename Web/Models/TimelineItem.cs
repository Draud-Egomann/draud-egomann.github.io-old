namespace Web.Models;

public class TimelineItem {
  public DateTime Year { get; set; }
  public string Title { get; set; } = default!;
  public string Description { get; set; } = default!;
  public List<string> Classes { get; set; } = [];
}
