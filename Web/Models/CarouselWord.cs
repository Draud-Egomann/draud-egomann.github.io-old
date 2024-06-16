namespace Web.Models;

public class CarouselWord
{
  public string Word { get; set; } = default!;
  public string ImageUrl { get; set; } = string.Empty;
  public string AltText { get; set; } = string.Empty;
  public double AnimationDelay { get; set; }
}
