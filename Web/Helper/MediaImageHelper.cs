using Web.Models;

namespace Web.Helper;

public static class MediaImageHelper
{
  public static List<MediaImage> GetMediaImages() {
    return [
      new () {
        ImageUrl = "./imgs/hobbies/write.jpg",
        AltText = "Schreiben",
        Text = ""
      },
      new () {
        ImageUrl = "./imgs/hobbies/program.webp",
        AltText = "Programmieren und Coden",
        Text = ""
      },
      new () {
        ImageUrl = "./imgs/hobbies/gaming.webp",
        AltText = "Gaming",
        Text = ""
      },
      new () {
        ImageUrl = "./imgs/hobbies/read.jpg",
        AltText = "Lesen",
        Text = ""
      },
    ];
  }
}
