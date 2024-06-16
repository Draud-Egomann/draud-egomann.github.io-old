using Web.Models;

namespace Web.Helper;

public static class HorizontalGalleryImageHelper
{
  public static List<HorizontalGalleryImage> GetGalleryImages() {
    return [
      new() { Id = 1, ImageUrl = "https://loremflickr.com/320/240/dog", AltText = "Image 1", Position = "lg:-top-[22rem] lg:right-[13rem]", TranslateX = 0 },
      new() { Id = 2, ImageUrl = "https://loremflickr.com/320/240/cat", AltText = "Image 2", Position = "lg:-top-[9rem] lg:right-[4rem]", TranslateX = 0 },
      new() { Id = 3, ImageUrl = "https://loremflickr.com/320/240/paris", AltText = "Image 3", Position = "lg:top-[3rem] lg:right-[16rem]", TranslateX = 0 },
    ];
  }
}
