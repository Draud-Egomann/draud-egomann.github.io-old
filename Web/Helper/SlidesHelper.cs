using Web.Models;

namespace Web.Helper;

public static class SlidesHelper {
  public static List<Slide> GetSlides() {
    return [
      new() {
        ImageUrl = "https://placehold.co/256x256",
        Thumbnail = "https://placehold.co/256x256",
        AltText = "Image 1",
        Caption = "Caption for image 1"
      },
      new() {
        ImageUrl = "https://placehold.co/256x256",
        Thumbnail = "https://placehold.co/256x256",
        AltText = "Image 2",
        Caption = "Caption for image 2"
      },
      new() {
        ImageUrl = "https://placehold.co/256x256",
        Thumbnail = "https://placehold.co/256x256",
        AltText = "Image 3",
        Caption = "Caption for image 3"
      },
      new() {
        ImageUrl = "https://placehold.co/256x256",
        Thumbnail = "https://placehold.co/256x256",
        AltText = "Image 4",
        Caption = "Caption for image 4"
      }
    ];
  }
}
