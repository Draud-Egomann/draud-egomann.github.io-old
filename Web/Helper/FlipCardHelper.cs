﻿using Web.Models;

namespace Web.Helper;

public static class FlipCardHelper {
  public static List<FlipCardItem> GetFlipCards() {
    return [
      new() { FrontText = "Mein Wohnort", BgImage = "https://images.pexels.com/photos/39811/pexels-photo-39811.jpeg?auto=compress&cs=tinysrgb&h=350" },
      new() { FrontText = "Mein Beruf", BgImage = "https://images.pexels.com/photos/374746/pexels-photo-374746.jpeg?auto=compress&cs=tinysrgb&h=350" },
      new() { FrontText = "Meine Lieblingsfarbe", BgImage = "https://images.pexels.com/photos/276724/pexels-photo-276724.jpeg?auto=compress&cs=tinysrgb&h=350" },
      new() { FrontText = "Mein Lieblingsessen", BgImage = "https://images.pexels.com/photos/461198/pexels-photo-461198.jpeg?auto=compress&cs=tinysrgb&h=350" },
    ];
  }
}
