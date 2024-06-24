using Web.Models;

namespace Web.Helper;

public static class MediaImageHelper
{
  public static List<MediaImage> GetMediaImages() {
    return [
      new () {
        ImageUrl = "./imgs/hobbies/write.jpg",
        AltText = "Kreatives Schreiben",
        Text = "Meine grösste Leidenschaft widmet sich dem kreativen Schreiben. Ich habe herausgefunden, dass das Verfassen und Ausdenken von Geschichten das ist, was mich persönlich am meisten erfüllt. Momentan schreibe ich nur kleinere Werke oder Konzepte."
      },
      new () {
        ImageUrl = "./imgs/hobbies/program.webp",
        AltText = "Programmieren und Coden",
        Text = "Programmieren ist ein Hobby, mit dem man seine Freizeit sinnvoll verbringen kann und das auch Teil des Berufs sein kann. Ich programmiere gerne das Frontend, aber auch die Backend-Logik von Websites. Die Sprachen, die ich benutze, sind C#, JS/TS, Python und leider auch PHP 😪."
      },
      new () {
        ImageUrl = "./imgs/hobbies/gaming.webp",
        AltText = "Gaming",
        Text = "Ich bin das, was man als leidenschaftlichen Gamer bezeichnen würde, auch wenn diese Leidenschaft immer mehr in den Hintergrund gerät. Meine Lieblingsgenres sind RPGs, Hack'n'Slay und MMOs und glaube an die PC-Supremacy."
      },
      new () {
        ImageUrl = "./imgs/hobbies/read.jpg",
        AltText = "Lesen",
        Text = "Ein immer mehr aufkommendes Hobby ist das Lesen. Ich lese gerne Bücher, um meinen Wortschatz zu erweitern und um mich in andere Welten zu versetzen. Meine Lieblingsgenres sind Fantasy, Sci-Fi und Thriller."
      },
    ];
  }
}
