using Web.Models;

namespace Web.Helper;

public static class TimelineItemHelper {
  public static List<TimelineItem> GetTimelineItems() {
    return [
      new() {
        StartYear = new DateTime(2011, 1, 1),
        EndYear = new DateTime(2020, 6, 27),
        Title = "Obligatorische Schulzeit",
        Description = "Obligatorische Schulzeit an der Primarschule und Sekundarschule in Luzern. Abschluss der Sekundarschule im Sommer 2020."
      },
      new () {
        StartYear = new DateTime(2020, 8, 19),
        EndYear = new DateTime(2021, 7, 5),
        Title = "Zentrum für Brückenangebote (ZBA) Luzern",
        Description = "Besuch des Zentrums für Brückenangebote (ZBA) in Luzern. Während dieser Zeit konnte ich meine schulischen Leistungen verbessern und mich auf die berufliche Ausbildung vorbereiten."
      },
      new() {
        StartYear = new DateTime(2021, 2, 1),
        EndYear = new DateTime(2025, 8, 1),
        Title = "Berufliche Ausbildung als Informatiker Applikationsentwicklung (Kauz Informatik Medien AG)",
        Description = "Berufliche Ausbildung als Informatiker Applikationsentwicklung bei der Kauz Informatik Medien AG in Ballwil. Während der Ausbildung wurde ich mit dem Google Workspace, sämtlichen Front- und Backendtechnologien, sowie der Konzeption und Umsetzung von Webapplikationen vertraut gemacht. Nahen Kundenkontakt gehörte ebenfalls zu meinen Aufgaben.",
      },
      new() {
        StartYear = new DateTime(2021, 8, 19),
        EndYear = new DateTime(2025, 7, 5),
        Title = "Berufsliche Ausbildung als Informatiker Applikationsentwicklung (BBZW Sursee)",
        Description = "Während dem theoretischen Teil der beruflichen Ausbildung besuche ich das Berufsbildungszentrum für Wirtschaft und Informatik (BBZW) in Sursee. Dort habe ich neben den Grundlagen des Unterrichts, Kenntnisse über Microsoft Office erlangt."
      },
    ];
  }
}
