using System.Globalization;

namespace Web.Services;

public class CultureService {
  public static List<CultureInfo> SupportedCultures { get; } = [
    new CultureInfo("de-CH"),
    new CultureInfo("en-US")
  ];

  public static CultureInfo CurrentCulture { get; set; } = SupportedCultures[0];

  public static void SetCulture(CultureInfo culture) {
    if (!SupportedCultures.Contains(culture)) {
      throw new NotSupportedException($"The culture '{culture.Name}' is not supported.");
    }

    CultureInfo.CurrentCulture = culture;
    CultureInfo.CurrentUICulture = culture;
    CurrentCulture = culture;
  }
}
