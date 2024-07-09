using Microsoft.Extensions.Localization;
using Web.Components.Layout;
using Web.Components.Pages;
using Web.Models;

namespace Web.Services;

public class MockData(IStringLocalizer<NavMenu> localizer) {
  private IStringLocalizer<NavMenu> Localizer { get; } = localizer;

  public List<NavLinkView> GetNavBarLinks(IStringLocalizer<NavMenu> Localizer) => [
    new() { Name = Localizer["HomeLink"], Url = "" },
    new() { Name = Localizer["AboutMeLink"], Url = "/about" },
    new() { Name = Localizer["ExperienceLink"], Url = "/experience" },
    new() { Name = Localizer["ProjectsLink"], Url = "/projects" },
    new() { Name = Localizer["ContactLink"], Url = "/contact" }
  ];

  public static List<MediaLinkItem> GetExperienceContent() => [
    new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 1" },
    new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 2" },
    new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 3" },
    new() { ImageUrl = "https://placehold.co/386x256", Title = "Experience 4" }
  ];

  public List<FlipCardItem> GetFlipCards(IStringLocalizer<About> Localizer) => [
    new() {
      FrontText = Localizer["AboutMeResidence"],
      BgImage = "./imgs/flipCards/lucerne.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeWork"],
      BgImage = "./imgs/flipCards/work.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeColor"],
      BgImage = "./imgs/flipCards/violet.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeFood"],
      BgImage = "./imgs/flipCards/food.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeAnimal"],
      BgImage = "./imgs/flipCards/wolf.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeSeason"],
      BgImage = "./imgs/flipCards/winter.jpg"
    },
    new() {
      FrontText = Localizer["AboutMeDrink"],
      BgImage = "./imgs/flipCards/water.jpg"
    },
  ];

  public List<CarouselWord> GetCarouselWords() => [
    new() { Word = "WordPress", ImageUrl = "./imgs/logos/wordpress.svg", AltText = "WordPress Logo", AnimationDelay = 0 },
    new() { Word = "ASP .NET", ImageUrl = "./imgs/logos/dotnet.svg", AltText = "ASP .NET Logo", AnimationDelay = 0 },
    new() { Word = "Ionic", ImageUrl = "./imgs/logos/ionic.svg", AltText = "Ionic Logo", AnimationDelay = 0 },
    new() { Word = "VueJS", ImageUrl = "./imgs/logos/vue.svg", AltText = "VueJS Logo", AnimationDelay = 0 },
    new() { Word = "TailwindCSS", ImageUrl = "./imgs/logos/tailwind.svg", AltText = "TailwindCSS Logo", AnimationDelay = 0 },
  ];

  public List<MediaImage> GetMediaImages(IStringLocalizer<About> Localizer) => [
    new () {
      ImageUrl = "./imgs/hobbies/write.jpg",
      AltText = Localizer["HobbiesAltTextWriting"],
      Text = Localizer["HobbiesTextWriting"]
    },
    new () {
      ImageUrl = "./imgs/hobbies/program.webp",
      AltText = Localizer["HobbiesAltTextProgramming"],
      Text = Localizer["HobbiesTextProgramming"]
    },
    new () {
      ImageUrl = "./imgs/hobbies/gaming.webp",
      AltText = Localizer["HobbiesAltTextGaming"],
      Text = Localizer["HobbiesTextGaming"]
    },
    new () {
      ImageUrl = "./imgs/hobbies/read.jpg",
      AltText = Localizer["HobbiesAltTextReading"],
      Text = Localizer["HobbiesTextReading"]
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

  public static List<ContactCard> GetContactCards() => [
    new() {
      ImageUrl = "./imgs/logos/discord-logo-white.svg",
      AltText = "Discord-Tag",
      Text = "LoremIpsum#53893"
    },
    new() {
      ImageUrl = "./imgs/logos/GitHub_Logo_White.png",
      AltText = "Github",
      Text = "Github Profile",
      IsLink = true,
      LinkUrl = "https://github.com/Egomann88"
    },
    new() {
      ImageUrl = "./imgs/logos/LI-Logo.png",
      AltText = "Linkedin",
      Text = "Linkedin",
      IsLink = true,
      LinkUrl = "https://www.linkedin.com/in/ju-573795244"
    }
  ];

  public static List<SourceImage> GetSourceImages() => [
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

  public static List<SourceIcon> GetSourceIcons() => [
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

  public static List<SourceCard> GetContactSourceCards() => [
    new() {
      ImageUrl = "/imgs/logos/discord-logo-white.svg",
      AltText = "Discord-Tag",
      ImageClass = "m-8 h-[85px]",
      Text = "Discord Brand",
      SourceUrl = "https://discord.com/branding"
    },
    new() {
      ImageUrl = "/imgs/logos/GitHub_Logo_White.png",
      AltText = "Github Logo",
      ImageClass = "m-8",
      Text = "Github Brand",
      SourceUrl = "https://github.com/logos"
    },
    new() {
      ImageUrl = "/imgs/logos/LI-Logo.png",
      AltText = "Linkedin Logo",
      ImageClass = "m-8",
      Text = "Linkedin Brand",
      SourceUrl = "https://brand.linkedin.com/en-us"
    }
  ];

  public static List<SourceCard> GetHobbiesSourceCards() => [
    new() {
      ImageUrl = "/imgs/hobbies/gaming.webp",
      AltText = "Bild von the Witcher 3",
      Title = "The Witcher 3 Wallpaper",
      Text = "Ein freies Bild von Luiz Eduardo auf Pinterest.",
      SourceUrl = "https://www.pinterest.com/pin/772226667335267334/"
    },
    new() {
      ImageUrl = "/imgs/hobbies/program.webp",
      AltText = "KI generiertes Bild über Programmieren",
      Title = "Mit KI generiert",
      Text = "Das Bild wurde auf meinen Auftrag von GPT-4 DALL·E generiert.",
    },
    new() {
      ImageUrl = "/imgs/hobbies/read.jpg",
      AltText = "Bild von einem Buch",
      Title = "Buchlampe",
      Text = "Ein freies Bild von jadeharmony1111 auf Pintrest.",
      SourceUrl = "https://www.pinterest.com/pin/641411171899245887/"
    },
    new() {
      ImageUrl = "/imgs/hobbies/write.jpg",
      AltText = "Bild von einem Notizbuch",
      Title = "Mit KI generiert",
      Text = "Das Bild wurde auf meinen Auftrag von GPT-4 DALL·E generiert.",
    }
  ];
}
