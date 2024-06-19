using Web.Models;

namespace Web.Helper;

public static class MediaImageHelper
{
  public static List<MediaImage> GetMediaImages() {
    return [
      new () {
        ImageUrl = "./imgs/hobbies/write.jpg",
        AltText = "Placeholder",
        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
      },
      new () {
        ImageUrl = "./imgs/hobbies/program.webp",
        AltText = "Placeholder",
        Text = ""
      },
      new () {
        ImageUrl = "./imgs/hobbies/gaming.webp",
        AltText = "Gaming",
        Text = ""
      },
      new () {
        ImageUrl = "./imgs/hobbies/read.jpg",
        AltText = "Placeholder",
        Text = ""
      },
    ];
  }
}
