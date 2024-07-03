using System.Globalization;

namespace Web.Services;

public class CultureService {
  public static List<CultureInfo> SupportedCultures { get; } = [
    new CultureInfo("en-US"),
    new CultureInfo("de-CH")
  ];

  public static CultureInfo CurrentCulture { get; set; } = SupportedCultures[1];
  public static event Action OnCultureChanged;

  public static void SetCulture(CultureInfo culture) {
    if (!SupportedCultures.Contains(culture)) {
      throw new NotSupportedException($"The culture '{culture.Name}' is not supported.");
    }

    CultureInfo.CurrentCulture = culture;
    CultureInfo.CurrentUICulture = culture;
    CurrentCulture = culture;
    OnCultureChanged?.Invoke();
  }
}
