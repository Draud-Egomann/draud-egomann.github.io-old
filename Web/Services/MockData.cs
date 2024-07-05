﻿using Microsoft.Extensions.Localization;
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

  public List<TimelineItem> GetTimelineItems() => [
    new() {
      StartYear = new DateTime(2011, 1, 1),
      EndYear = new DateTime(2020, 6, 27),
      Title = Localizer["TimelineTitle1"],
      Description = Localizer["TimelineDescription1"]
    },
    new () {
      StartYear = new DateTime(2020, 8, 19),
      EndYear = new DateTime(2021, 7, 5),
      Title = Localizer["TimelineTitle2"],
      Description = Localizer["TimelineTitle2"],
    },
    new() {
      StartYear = new DateTime(2021, 2, 1),
      EndYear = new DateTime(2025, 8, 1),
      Title = Localizer["TimelineTitle3"],
      Description = Localizer["TimelineTitle3"],
    },
    new() {
      StartYear = new DateTime(2021, 8, 19),
      EndYear = new DateTime(2025, 7, 5),
      Title = Localizer["TimelineTitle4"],
      Description = Localizer["TimelineTitle4"]
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
      ImageUrl = "https://via.placeholder.com/800x300",
      AltText = "Placeholder image",
      Text = "This is a placeholder image"
    },
    new() {
      ImageUrl = "https://via.placeholder.com/800x300",
      AltText = "Placeholder image",
      Text = "This is a placeholder image"
    }
  ];
}
