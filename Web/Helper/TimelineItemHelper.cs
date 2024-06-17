using Web.Models;

namespace Web.Helper;

public static class TimelineItemHelper {
  public static List<TimelineItem> GetTimelineItems() {
    return [
      new() {
        Year = new DateTime(2019, 1, 1),
        Title = "Lorem Ipsum dolor",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
      },
      new() {
        Year = new DateTime(2019, 2, 1),
        Title = "Lorem Ipsum dolor",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
      },
      new() {
        Year = new DateTime(2020, 1, 1),
        Title = "Lorem Ipsum dolor",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
      },
      new() {
        Year = new DateTime(2020, 2, 1),
        Title = "Lorem Ipsum dolor",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
      },
      new() {
        Year = new DateTime(2021, 1, 1),
        Title = "Lorem Ipsum dolor",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
      },
    ];
  }
}
