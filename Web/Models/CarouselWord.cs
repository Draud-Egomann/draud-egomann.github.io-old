namespace Web.Models;

public class CarouselWord : ImageItem {
  public string Word { get; set; } = default!;
  public double AnimationDelay { get; set; }
}
