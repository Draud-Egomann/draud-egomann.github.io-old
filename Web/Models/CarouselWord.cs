namespace Web.Models;

public class CarouselWord : ImageBaseItem {
  public string Word { get; set; } = default!;
  public double AnimationDelay { get; set; }
}
