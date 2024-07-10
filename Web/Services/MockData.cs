using Microsoft.Extensions.Localization;
using System.Security.Cryptography.Xml;
using Web.Components.Layout;
using Web.Components.Pages;
using Web.Models;

namespace Web.Services;

public class MockData {
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
      Title = "Project 1",
      Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed nonne merninisti licere mihi ista probare, quae sunt a te dicta? Refert tamen, quo modo.",
      HasMoreInfo = true,
      MoreInfoText = "More Info",
      Classes = []
    },
    new() {
      Title = "Project 2",
      Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed nonne merninisti licere mihi ista probare, quae sunt a te dicta? Refert tamen, quo modo.",
      HasMoreInfo = true,
      MoreInfoText = "More Info",
      Classes = []
    }
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
