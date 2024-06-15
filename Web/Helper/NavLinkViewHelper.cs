using Web.Models;

namespace Web.Helper;

public static class NavLinkViewHelper
{
  public static List<NavLinkView> GetNavBarLinks() {
    return [
      new() { Name = "Home", Url = "" },
      new() { Name = "Über mich", Url = "/about" },
      new() { Name = "Erfahrung", Url = "/experience" },
      new() { Name = "Projekte", Url = "/projects" },
      new() { Name = "Kontakt", Url = "/contact" }
    ];
  }
}
