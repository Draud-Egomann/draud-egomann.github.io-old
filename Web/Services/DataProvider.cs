using Microsoft.Extensions.Localization;
using Web.Components.Enums;
using Web.Components.Layout;
using Web.Components.Pages;
using Web.Models;

namespace Web.Services;

public class DataProvider {
  public List<string[]> GetNavBarLinks(IStringLocalizer<NavMenu> Localizer) => [
    [Localizer["HomeLink"], ""],
    [Localizer["AboutMeLink"], "/about"],
    [Localizer["ExperienceLink"], "/experience"],
    [Localizer["ProjectsLink"], "/projects"],
    [Localizer["ContactLink"], "/contact"]
  ];

  public static List<MediaItem> GetExperienceContent() => [
    new() { ImageUrl = "https://placehold.co/386x256", AltText = "Placeholder", Title = "Experience 1", LinkUrl = "https://www.example.com/" },
    new() { ImageUrl = "https://placehold.co/386x256", AltText = "Placeholder", Title = "Experience 2", LinkUrl = "https://www.example.com/" },
    new() { ImageUrl = "https://placehold.co/386x256", AltText = "Placeholder", Title = "Experience 3", LinkUrl = "https://www.example.com/" },
    new() { ImageUrl = "https://placehold.co/386x256", AltText = "Placeholder", Title = "Experience 4", LinkUrl = "https://www.example.com/" }
  ];

  public List<FlipCardItem> GetFlipCards(IStringLocalizer<About> Localizer) => [
    new() {
      FrontText = Localizer["AboutMeResidence"],
      ImageUrl = "./imgs/flipCards/lucerne.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeWork"],
      ImageUrl = "./imgs/flipCards/work.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeColor"],
      ImageUrl = "./imgs/flipCards/violet.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeFood"],
      ImageUrl = "./imgs/flipCards/food.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeAnimal"],
      ImageUrl = "./imgs/flipCards/wolf.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeSeason"],
      ImageUrl = "./imgs/flipCards/winter.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeDrink"],
      ImageUrl = "./imgs/flipCards/water.jpg"
    },
  ];

  public List<CarouselWord> GetCarouselWords() => [
    new() { Word = "WordPress", ImageUrl = "./imgs/logos/wordpress.svg", AltText = "WordPress Logo", AnimationDelay = 0 },
    new() { Word = "ASP .NET", ImageUrl = "./imgs/logos/dotnet.svg", AltText = "ASP .NET Logo", AnimationDelay = 0 },
    new() { Word = "Ionic", ImageUrl = "./imgs/logos/ionic.svg", AltText = "Ionic Logo", AnimationDelay = 0 },
    new() { Word = "VueJS", ImageUrl = "./imgs/logos/vue.svg", AltText = "VueJS Logo", AnimationDelay = 0 },
    new() { Word = "TailwindCSS", ImageUrl = "./imgs/logos/tailwind.svg", AltText = "TailwindCSS Logo", AnimationDelay = 0 },
  ];

  public List<MediaItem> GetMediaImages(IStringLocalizer<About> Localizer) => [
    new () {
      ImageUrl = "./imgs/hobbies/write.jpg",
      AltText = Localizer["HobbiesAltTextWriting"],
      Description = Localizer["HobbiesTextWriting"]
    },
    new () {
      ImageUrl = "./imgs/hobbies/program.webp",
      AltText = Localizer["HobbiesAltTextProgramming"],
      Description = Localizer["HobbiesTextProgramming"]
    },
    new () {
      ImageUrl = "./imgs/hobbies/gaming.webp",
      AltText = Localizer["HobbiesAltTextGaming"],
      Description = Localizer["HobbiesTextGaming"]
    },
    new () {
      ImageUrl = "./imgs/hobbies/read.jpg",
      AltText = Localizer["HobbiesAltTextReading"],
      Description = Localizer["HobbiesTextReading"]
    },
  ];

  public List<TimelineItem> GetTimelineItems(IStringLocalizer<Experience> Localizer) => [
    new() {
      StartYear = new DateTime(2011, 1, 1),
      EndYear = new DateTime(2020, 6, 27),
      Title = Localizer["TimelineTitle1"],
      Description = Localizer["TimelineText1"]
    },
    new () {
      StartYear = new DateTime(2020, 8, 19),
      EndYear = new DateTime(2021, 7, 5),
      Title = Localizer["TimelineTitle2"],
      Description = Localizer["TimelineText2"],
    },
    new() {
      StartYear = new DateTime(2021, 2, 1),
      EndYear = new DateTime(2025, 8, 1),
      Title = Localizer["TimelineTitle3"],
      Description = Localizer["TimelineText3"],
    },
    new() {
      StartYear = new DateTime(2021, 8, 19),
      EndYear = new DateTime(2025, 7, 5),
      Title = Localizer["TimelineTitle4"],
      Description = Localizer["TimelineText4"]
    },
  ];

  public static List<ProjectMenuItem> GetProjectMenuItems() => [
    new() {
      Title = "Kauz Website",
      Description = "Die Kauz Website war ein Projekt zur Neugestaltung der Website der Kauz Informatik Medien AG. Ich habe unter anderem bei der Umsetzung des Designs geholfen.",
      MoreInfoText = "Dies war ein internes Projekt und zu meinen Aufgaben gehörte es, Gestaltungselemente umzusetzen, dabei war ich frei wie die Elemente aussehen sollten, solange Benutzerfreundlichkeit, Funktionalität und die Grundanforderungen gewährleistet waren. Der Source-Code, sowie genaue Details sind nicht öffentlich verfügbar.",
      Status = ProjectStatus.Completed,
      LinkToLiveSite = "https://kauz.ch",
      Slides = [
        new () {
          ImageUrl = "./imgs/projects/kimWebsite/img1.jpg",
          ThumbnailUrl = "./imgs/projects/kimWebsite/img1.jpg",
          AltText = "Projektbild",
          Description = string.Empty
        },
        new () {
          ImageUrl = "./imgs/projects/kimWebsite/img2.jpg",
          ThumbnailUrl = "./imgs/projects/kimWebsite/img2.jpg",
          AltText = "Projektbild",
          Description = string.Empty
        },
        new () {
          ImageUrl = "./imgs/projects/kimWebsite/img3.jpg",
          ThumbnailUrl = "./imgs/projects/kimWebsite/img3.jpg",
          AltText = "Projektbild",
          Description = string.Empty
        }
      ]
    },
    new() {
      Title = "Magical Imagery",
      Description = "Magical Imagery war ein Pilotprojekt im Rahmen eines Modules in meiner Ausbildung. Es ist ein Webshop für Fotografie und Kunst, dessen Zielgebung es war, eine einfache Plattform für Künstler zu schaffen, um ihre Werke zu verkaufen.",
      MoreInfoText = "Ein Webshop der sowohl privaten als auch geschäftliche Bedürfnisse abdecken sollte. Die Herausforderung bestand darin, eine einfache und intuitive Benutzeroberfläche zu schaffen, die sowohl für Künstler als auch für Kunden einfach zu bedienen ist. Die Beweggründe für diese Idee war es, Künstlern das leben zu vereinfachen und sie auf unserer Plattform ihre Werke ohne die rechtlichen Hürden eines eigenen Shops zu verkaufen. Freiheit für KI generierte Kunstwerke wollten wir auch bieten.",
      Status = ProjectStatus.Completed,
      LinkToSourceCode = "https://github.com/cooleGruppe/Magical-Imagery",
      Slides = [
        new() {
          ImageUrl = "./imgs/projects/magicalImagery/img1.jpg",
          ThumbnailUrl = "./imgs/projects/magicalImagery/img1.jpg",
          AltText = "Projektbild",
          Description = "Index Page"
        },
        new() {
          ImageUrl = "./imgs/projects/magicalImagery/img2.jpg",
          ThumbnailUrl = "./imgs/projects/magicalImagery/img2.jpg",
          AltText = "Projektbild",
          Description = "Detaillierte Ansicht"
        },
        new() {
          ImageUrl = "./imgs/projects/magicalImagery/img3.jpg",
          ThumbnailUrl = "./imgs/projects/magicalImagery/img3.jpg",
          AltText = "Projektbild",
          Description = "Lizenzmodelle"
        },
        new() {
          ImageUrl = "./imgs/projects/magicalImagery/img4.jpg",
          ThumbnailUrl = "./imgs/projects/magicalImagery/img4.jpg",
          AltText = "Projektbild",
          Description = "Warenkorb"
        },
        new() {
          ImageUrl = "./imgs/projects/magicalImagery/img5.jpg",
          ThumbnailUrl = "./imgs/projects/magicalImagery/img5.jpg",
          AltText = "Projektbild",
          Description = "Produkt erstellen"
        },
      ]
    },  
    new() {
      Title = "Blazor Templates",
      Description = "Die Blazor Templates sind eine kleine Anreihung an Vorlagen für Blazor Web Projekte. Sie sind für Entwickler gedacht, die schnell und einfach eine Vorlage für ihre Projekte suchen.",
      MoreInfoText = "Alle Blazor Vorlagen bestehen aus derselben Struktur, welche die Datenbank-Logik und die Benutzeroberfläche trennt; geschrieben als Blazor Web-App. Im Moment gibt es 4 Vorlagen: Eine normale Blazor Web-App, die normale mit Radzen als UI-Libary und zwei weitere normale mit Blazorise als UI-Libary; eine mit TailwindCSS und die andere mit Bootstrap.",
      Status = ProjectStatus.InProgress,
      LinkToSourceCodes = [
        "https://github.com/Egomann88/BlazorWebTemplate",
        "https://github.com/Egomann88/BlazorRazdenTemplate",
        "https://github.com/Egomann88/BlazorBlazoriseTailwindTemplate",
        "https://github.com/Egomann88/BlazorBlazoriseBootstrapTemplate",
      ],
      Slides = null
    },
    new() {
      Title = "Hackathon",
      Description = "2022 habe ich mit vier Kollegen an dem Young Talents Hackathon, organisiert von der UMB AG und der ICT-Berufsbildung Zentralschweiz, teilgenommen. Wir sollten für die HSLU einen Ferienplanner für die Angestellten entwickeln.",
      MoreInfoText = "Die effektive Umsetzung war eher mager; es war unser erster Versuch eine Web-App zu entwickeln. Schlussendlich haben wir eine einfache Web-App mit VueJs als Frontend und .Net als REST-Api entwickelt und präsentiert. Viel ist nicht daraus geworden, aber es war eine interessante Erfahrung.",
      Status = ProjectStatus.Completed,
      LinkToSourceCode = "https://github.com/Egomann88/newHackathonDJMN",
      Slides = [
        new () {
          ImageUrl = "./imgs/projects/hackathon/img1.jpg",
          ThumbnailUrl = "./imgs/projects/hackathon/img1.jpg",
          AltText = "Projektbild",
          Description = "Login"
        },
        new() {
          ImageUrl = "./imgs/projects/hackathon/img2.jpg",
          ThumbnailUrl = "./imgs/projects/hackathon/img2.jpg",
          AltText = "Projektbild",
          Description = "Kalender"
        },
        new() {
          ImageUrl = "./imgs/projects/hackathon/img3.jpg",
          ThumbnailUrl = "./imgs/projects/hackathon/img3.jpg",
          AltText = "Projektbild",
          Description = "Beantragte Ferien"
        }
      ]
    },
    new() {
      Title = "Scavenger-Hunt-Ionic-App",
      Description = "Die Scavenger-Hunt ist wie man von dem Namen ableiten kann, eine Schnitzeljagd-App. Diese kleine App wurde von mir und zwei Kollegen im Rahmen eines ÜKs entwickelt.",
      MoreInfoText = "Die App ist in Ionic und Angular geschriebenen. In der App kann man Schnitzeljagten mit insgesamt 6 Aufgaben machen, in dem Kartoffeln verteilt werden, wenn man zu viel Zeit bei einem Auftrag verbraucht. Alle Schnitzeljagten kann man in einer Rangliste einsehen. Die Daten werden im lokalen Speicher des Gerätes gespeichert, dazu wurden damals zur bearbeitung der ÜKs die Leistungen der Spieler in einer Google Tabelle gespeichert. Der Source-Code ist derzeit nicht öffentlich verfügbar.",
      Status = ProjectStatus.Completed,
      LinkToSourceCode = null, // https://github.com/BBZW-Hoard/Scavenger-Hunt-Ionic-App
      Slides = [
        new() {
          ImageUrl = "./imgs/projects/scavengerHunt/img1.jpg",
          ThumbnailUrl = "./imgs/projects/scavengerHunt/img1.jpg",
          AltText = "Projektbild",
          Description = "Startseite und Rangliste"
        },
        new() {
          ImageUrl = "./imgs/projects/scavengerHunt/img2.jpg",
          ThumbnailUrl = "./imgs/projects/scavengerHunt/img2.jpg",
          AltText = "Projektbild",
          Description = "1. Aufgabe: Sensor"
        },
        new() {
          ImageUrl = "./imgs/projects/scavengerHunt/img3.jpg",
          ThumbnailUrl = "./imgs/projects/scavengerHunt/img3.jpg",
          AltText = "Projektbild",
          Description = "2. Aufgabe: Laufen"
        },
        new() {
          ImageUrl = "./imgs/projects/scavengerHunt/img4.jpg",
          ThumbnailUrl = "./imgs/projects/scavengerHunt/img4.jpg",
          AltText = "Projektbild",
          Description = "4. Aufgabe: Schütteln bzw. Drehen"
        },
        new () {
          ImageUrl = "./imgs/projects/scavengerHunt/img5.jpg",
          ThumbnailUrl = "./imgs/projects/scavengerHunt/img5.jpg",
          AltText = "Projektbild",
          Description = "Ende und Auswertung"
        }
      ]
    },
    new() {
      Title = "Powershell Word-Header replacer",
      Description = "Das Powershell Word-Header replacer ist ein kleines Skript, welches ein Kollege und ich in unserem 1. Lehrjahr innerhalb von 3 Tagen entwickelt haben. Ziel des Skripts war es die Kopf und Fusszeilen von Word-Dokumenten mit dennen von einem anderen Dokument zu ersetzen.",
      MoreInfoText = "Eine Lehrperson hatte uns gefragt, ob wir ein solches Skript entwickeln könnten, da sie es für ihre Arbeit benötigte und PowerShell war als Sprache vorgegeben. Das Skript benutzt die eingebaute Word API von Microsoft und kann die Kopf und Fusszeilen von Word-Dokumenten ersetzen, aber leider funktioniert es nicht immer. Ich habe viele Versuche unternommen, um das Skript zu verbessern, aber diese Versuche haben keine Früchte getragen.",
      Status = ProjectStatus.Unknown,
      LinkToSourceCode = "https://github.com/Egomann88/PSCopyFromWord2Word",
      Slides = [
        new() {
          ImageUrl = "./imgs/projects/wordHeaderReplacer/img1.jpg",
          ThumbnailUrl = "./imgs/projects/wordHeaderReplacer/img1.jpg",
          AltText = "Projektbild",
        },
      ]
    },
    new() {
      Title = "Mongo Python",
      Description = "Mongo Python heisst eigentlich Jukebox und ist ein Abschlussprojekt eines Moduls, entwicklet von mir und einem Kollegen. Es ist eine kleine Web-App, die Musik abspielen kann und die Musik in einer MongoDB speichert.",
      MoreInfoText = "Ziel des Projekts war es, eine Web-App zu entwickeln, die Musik abspielen kann, diese in Playlist speichern kann und die Musik in einer MongoDB speichert. Die Web-App sollte auch eine Benutzeroberfläche haben, um die Musik zu verwalten. Umgesetzt wurde das Projekt mit VueJs als Frontend und Python als Backend. Die Datenbank wurde mit einer Dockerfile erstellt.",
      Status = ProjectStatus.Completed,
      LinkToSourceCode = "https://github.com/dominictosku/Mongo-Python",
      Slides = null
    },
  ];

  public static List<MediaItem> GetContactCards() => [
    new() {
      ImageUrl = "./imgs/logos/discord-logo-white.svg",
      AltText = "Discord-Tag",
      Title = "LoremIpsum#53893"
    },
    new() {
      ImageUrl = "./imgs/logos/GitHub_Logo_White.png",
      AltText = "Github",
      Title = "Github Profile",
      LinkUrl = "https://github.com/Egomann88"
    },
    new() {
      ImageUrl = "./imgs/logos/LI-Logo.png",
      AltText = "Linkedin",
      Title = "Linkedin",
      LinkUrl = "https://www.linkedin.com/in/ju-573795244"
    }
  ];

  public static List<ImageReference> GetRefrenceImages() => [
    new () {
      ImageUrl = "/imgs/flipCards/lucerne.jpg",
      AltText = "Lucerne from Pixabay",
      ProfileName = "B. Hochsprung",
      ProfileUrl = "https://pixabay.com/de/users/bea61-12517357/",
      SiteName = "Pixabay",
      SiteUrl = "https://pixabay.com/de/photos/europa-schweiz-luzern-stadt-7128531/"
    },
    new () {
      ImageUrl = "/imgs/flipCards/work.jpg",
      AltText = "Proamming form Pixabay",
      SiteName = "Pixabay",
      SiteUrl = "https://www.pexels.com/de-de/foto/computer-c-code-276452/"
    },
    new () {
      ImageUrl = "/imgs/flipCards/food.jpg",
      AltText = "Lasagne from Pixabay",
      ProfileName = "the_food _shot_",
      ProfileUrl = "https://www.pexels.com/de-de/@the_food-_shot_-445040244/",
      SiteName = "Pixabay",
      SiteUrl = "https://www.pexels.com/de-de/foto/datei-aparmegiana-20426624/"
    },
    new() {
      ImageUrl = "/imgs/flipCards/wolf.jpg",
      AltText = "Wolf from Pixabay",
      ProfileName = "Andrea Bohl",
      ProfileUrl = "https://pixabay.com/de/users/wildfaces-932734/",
      SiteName = "Pixabay",
      SiteUrl = "https://pixabay.com/de/photos/wolf-eckzahn-wald-raubtier-wild-1336229/"
    },
    new() {
      ImageUrl = "/imgs/flipCards/winter.jpg",
      AltText = "Winter from Pixabay",
      ProfileName = "Nathalie De Boever",
      ProfileUrl = "https://www.pexels.com/de-de/@nathy/",
      SiteName = "Pixabay",
      SiteUrl = "https://www.pexels.com/de-de/foto/schneebedeckte-gebirgszuge-unter-dem-weissen-himmel-1398049/"
    },
    new() {
      ImageUrl = "/imgs/flipCards/water.jpg",
      AltText = "Water from Pixabay",
      SiteName = "Pixabay",
      SiteUrl = "https://www.pexels.com/de-de/foto/nahaufnahme-der-flasche-die-wasser-auf-glas-giesst-327090/"
    }
  ];

  public static List<MediaItem> GetRefrenceIcons() => [
    new() {
      ImageUrl = "/imgs/logos/ionic.svg",
      AltText = "ionic",
      Description = "Ionic Brand",
      LinkUrl = "https://ionic.io/about/brand"
    },
    new() {
      ImageUrl = "/imgs/logos/dotnet.svg",
      AltText = "aspnetcore",
      Description = "ASP.NET Core Brand",
      LinkUrl = "https://github.com/dotnet/brand/tree/main/logo"
    },
    new() {
      ImageUrl = "/imgs/logos/tailwind.svg",
      AltText = "tailwindcss",
      Description = "Tailwind CSS Brand",
      LinkUrl = "https://tailwindcss.com/brand"
    },
    new() {
      ImageUrl = "/imgs/logos/vue.svg",
      AltText = "vuejs",
      Description = "Vue.js Brand",
      LinkUrl = "https://vuejs.org/"
    },
    new() {
      ImageUrl = "/imgs/logos/wordpress.svg",
      AltText = "wordpress",
      Description = "WordPress Brand",
      LinkUrl = "https://wordpress.org/about/logos/"
    }
  ];

  public static List<MediaItem> GetContactRefrenceCards() => [
    new() {
      ImageUrl = "/imgs/logos/discord-logo-white.svg",
      AltText = "Discord-Tag",
      ImageClass = "m-8 h-[85px]",
      Description = "Discord Brand",
      LinkUrl = "https://discord.com/branding"
    },
    new() {
      ImageUrl = "/imgs/logos/GitHub_Logo_White.png",
      AltText = "Github Logo",
      ImageClass = "m-8",
      Description = "Github Brand",
      LinkUrl = "https://github.com/logos"
    },
    new() {
      ImageUrl = "/imgs/logos/LI-Logo.png",
      AltText = "Linkedin Logo",
      ImageClass = "m-8",
      Description = "Linkedin Brand",
      LinkUrl = "https://brand.linkedin.com/en-us"
    }
  ];

  public List<MediaItem> GetHobbiesRefrenceCards(IStringLocalizer<References> Localizer) => [
    new() {
      ImageUrl = "/imgs/hobbies/gaming.webp",
      AltText = "Image from witcher 3",
      Title = Localizer["HobbySourceCardGamingTitle"],
      Description = Localizer["HobbySourceCardGamingText"],
      LinkUrl = "https://www.pinterest.com/pin/772226667335267334/"
    },
    new() {
      ImageUrl = "/imgs/hobbies/program.webp",
      AltText = "AI generated Image about programming",
      Title = Localizer["HobbySourceCardAIGenTitle"],
      Description = Localizer["HobbySourceCardAIGenText"],
    },
    new() {
      ImageUrl = "/imgs/hobbies/read.jpg",
      AltText = "Image of an open Book",
      Title = Localizer["HobbySourceCardReadTitle"],
      Description = Localizer["HobbySourceCardReadText"],
      LinkUrl = "https://www.pinterest.com/pin/641411171899245887/"
    },
    new() {
      ImageUrl = "/imgs/hobbies/write.jpg",
      AltText = "Image of a Book",
      Title = Localizer["HobbySourceCardAIGenTitle"],
      Description = Localizer["HobbySourceCardAIGenText"],
    }
  ];
}
