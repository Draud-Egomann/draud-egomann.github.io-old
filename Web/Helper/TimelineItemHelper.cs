using Web.Models;

namespace Web.Helper;

public static class TimelineItemHelper {
  public static List<TimelineItem> GetTimelineItems() {
    return [
      new() {
        Index = 1,
        Year = "2019",
        Title = "First item",
        Description = "This is the first item in the timeline."
      },
      new() {
        Index = 2,
        Year = "2020",
        Title = "Second item",
        Description = "This is the second item in the timeline."
      },
      new() {
        Index = 3,
        Year = "2021",
        Title = "Third item",
        Description = "This is the third item in the timeline."
      }
    ];
  }
}
