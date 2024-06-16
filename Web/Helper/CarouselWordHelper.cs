using Web.Models;

namespace Web.Helper;

public static class CarouselWordHelper
{
  public static List<CarouselWord> GetCarouselWords() {
    return [
      new() { Word = "WordPress", ImageUrl = "https://placehold.co/64", AltText = "WordPress Logo", AnimationDelay = 0 },
      new() { Word = "ASP .NET", ImageUrl = "https://placehold.co/64", AltText = "ASP .NET Logo", AnimationDelay = 0 },
      new() { Word = "Ionic", ImageUrl = "https://placehold.co/64", AltText = "Ionic Logo", AnimationDelay = 0 },
      new() { Word = "VueJS", ImageUrl = "https://placehold.co/64", AltText = "VueJS Logo", AnimationDelay = 0 },
      new() { Word = "NuxtJS", ImageUrl = "https://placehold.co/64", AltText = "NuxtJS Logo", AnimationDelay = 0 }
    ];
  }
}
