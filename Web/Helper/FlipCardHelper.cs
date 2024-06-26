using Web.Models;

namespace Web.Helper;

public static class FlipCardHelper {
  public static List<FlipCardItem> GetFlipCards() {
    return [
      new() {
        FrontText = "Mein Wohnort",
        BgImage = "./imgs/flipCards/lucerne.jpg"
      },
      new() {
        FrontText = "Mein Beruf",
        BgImage = "./imgs/flipCards/work.jpg"
      },
      new() {
        FrontText = "Meine Lieblingsfarbe",
        BgImage = "./imgs/flipCards/violet.jpg"
      },
      new() {
        FrontText = "Mein Lieblingsessen",
        BgImage = "./imgs/flipCards/food.jpg"
      },
      new() {
        FrontText = "Mein Lieblingstier",
        BgImage = "./imgs/flipCards/wolf.jpg"
      },
      new() {
        FrontText = "Meine Lieblingsjahreszeit",
        BgImage = "./imgs/flipCards/winter.jpg"
      },
      new() {
        FrontText = "Mein Lieblingsgetränk",
        BgImage = "./imgs/flipCards/water.jpg"
      },
    ];
  }
}