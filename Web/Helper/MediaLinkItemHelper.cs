using Web.Models;

namespace Web.Helper;

public static class MediaLinkItemHelper
{
  public static List<MediaLinkItem> GetExperienceContent() {
    return [
      new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 1" },
      new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 2" },
      new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 3" },
      new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 4" }
    ];
  }
}
