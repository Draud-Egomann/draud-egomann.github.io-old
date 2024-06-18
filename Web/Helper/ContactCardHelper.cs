using Web.Models;

namespace Web.Helper;

public static class ContactCardHelper {
  public static List<ContactCard> GetContactCards() {
    return [
      new() {
        ImageUrl = "https://via.placeholder.com/800x300",
        AltText = "Placeholder image",
        Text = "This is a placeholder image"
      },
      new() {
        ImageUrl = "https://via.placeholder.com/800x300",
        AltText = "Placeholder image",
        Text = "This is a placeholder image"
      }
    ];
  }
}
