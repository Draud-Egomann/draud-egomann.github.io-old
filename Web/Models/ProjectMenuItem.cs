using Web.Components.Enums;

namespace Web.Models;

public class ProjectMenuItem {
  public string Title { get; set; } = default!;
  public string Description { get; set; } = default!;
  public bool HasMoreInfo => !string.IsNullOrEmpty(MoreInfoText);
  public string? MoreInfoText { get; set; }
  public ProjectStatus? Status { get; set; } // under more info
  public string? LinkToLiveSite { get; set; } // under more info
  public string? LinkToSourceCode { get; set; } // under more info
  public List<string>? LinkToSourceCodes { get; set; } // under more info ; if multiple source codes
  public List<string> Classes { get; set; } = [];
  public List<MediaItem>? Slides { get; set; }
}
