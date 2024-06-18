using Web.Models;

namespace Web.Helper;

public class ProjectMenuItemHelper {
  public static List<ProjectMenuItem> GetProjectMenuItems() {
    return [
      new() {
        Title = "Project 1",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed nonne merninisti licere mihi ista probare, quae sunt a te dicta? Refert tamen, quo modo.",
        HasMoreInfo = true,
        MoreInfoText = "More Info",
        Classes = []
      },
      new() {
        Title = "Project 2",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed nonne merninisti licere mihi ista probare, quae sunt a te dicta? Refert tamen, quo modo.",
        HasMoreInfo = true,
        MoreInfoText = "More Info",
        Classes = []
      }
    ];
  }
}
