#region 1. feladat
Console.Write("Adjon meg egy érdemjegyet: ");
Console.WriteLine(int.Parse(Console.ReadLine() ?? "") switch
{
    1 => "Elégtelen",
    2 => "Elégséges",
    3 => "Közepes",
    4 => "Jó",
    5 => "Jeles",
    _ => "Nincs ilyen érdemjegy!"
});
#endregion

#region 2.feladat
Console.Write("\nAdja meg egy hónap nevét: ");
switch ((Console.ReadLine() ?? "").ToLower())
{
    case "január":
    case "február":
    case "március":
        Console.WriteLine("Első negyedév");
        break;
    case "április":
    case "május":
    case "június":
        Console.WriteLine("Második negyedév");
        break;
    case "július":
    case "augusztus":
    case "szeptember":
        Console.WriteLine("Harmadik negyedév");
        break;
    case "október":
    case "november":
    case "december":
        Console.WriteLine("Negyedik negyedéve");
        break;
    default:
        Console.WriteLine("Nincs ilyen hónap!");
        break;
}
#endregion

#region 3.feladat
Console.Write("\nAdja meg egy hónap sorszámát: ");
Console.WriteLine(int.Parse(Console.ReadLine() ?? "") switch
{
    < 1 => "Nincs ilyen hónap",
    <= 2 => "Tél",
    <= 5 => "Tavasz",
    <= 8 => "Nyár",
    <= 11 => "Ősz",
    12 => "Tél",
    _ => "Nincs ilyen hónap"
});
#endregion

#region 4.feladat
Console.Write("\nAdja meg, hogy átlagosan hány órát alszik naponta: ");
Console.WriteLine(int.Parse(Console.ReadLine() ?? "") switch
{
    < 0 => "Csak természetes számot adhat meg!",
    <= 6 => "Kevés",
    <= 9 => "Átlagos",
    <= 12 => "Sok",
    <= 24 => "Nagyon sok",
    _ => "Egy nap 24 órából áll!"
});
#endregion

#region 5. feladat
Console.Write("\nAdjon megy egy szeptemberi napot: ");
int day = int.Parse(Console.ReadLine() ?? "");
var dateValue = new DateTime(2023, 09, day, 0, 0, 0, DateTimeKind.Utc);

Console.WriteLine(dateValue.DayOfWeek switch
{
    DayOfWeek.Monday => "Hétfő: Matek, Töri, Angol, Német, Irodalom, Tesi",
    DayOfWeek.Tuesday => "Kedd: Webprogramozás, IKT",
    DayOfWeek.Wednesday => "Szerda: Matek, Fizika, Tesi, Töri, Nyelvtan, Szakmai Angol",
    DayOfWeek.Thursday => "Csütörtök: Linux, Adatbázis, Asztali alkalmazás fejlesztés",
    DayOfWeek.Friday => "Péntek: Fizika, Irodalom, Matematika, Osztályfőnöki, Angol, Német, Tesi, Digitális kultúra",
    DayOfWeek.Saturday => "Szombat",
    DayOfWeek.Sunday => "Vasárnap",
    _ => "Nincs ilyen nap!"
});
#endregion

#region 6. feladat
Console.Write("\nAdja meg egy osztály jelét: ");
Console.WriteLine((Console.ReadLine() ?? "").ToLower() switch
{
    "9.ny" => "Forray Edina, 35. terem",
    "9.a" => "Menich Ilona, 120. terem",
    "9.b" => "Várkonyi Tibor Zoltán, 133. terem",
    "9.c" => "Tóthné Vers Éva, 44. terem",
    "9.d" => "Répásné Babucs Hajnalka, 125. terem",

    "10.a" => "Szokola Melinda, 129. terem",
    "10.b" => "Halász-Szabó Lídia Ildikó, 109. terem",
    "10.c" => "Rabina Roland Richárd, 233. terem",
    "10.d" => "Dobronayné Csepeti Melinda, 5. terem",

    "11.a" => "Révész Barnabás, 121. terem",
    "11.b" => "Németh Mónika, 114. terem",
    "11.c" => "Kiss Renáta, 45. terem",
    "11.d" => "Erdős Gábor, 33. terem",

    "12.a" => "Gönczy-Szabó Gabriella, 46. terem",
    "12.b" => "Mező György, 229. terem",
    "12.c" => "Veresné Murányi Marian, 205. terem",
    "12.d" => "Kiss Éva Csilla, 225. terem",
    "12.e" => "Tellér Gina Margit, 113. terem",

    "2/14.a" => "Bálint György, gt11/gt6",
    "2/14.b" => "Piedl Péter, gt11/gt5",

    _ => "Nincs ilyen osztály!"
});
#endregion

#region 7. feladat
Console.Write("\nAdjon meg egy számot: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adjon meg egy számot: ");
int b = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adjon meg egy műveleti jelet: ");
Console.WriteLine(Console.ReadLine() switch
{
    "+" => a + b,
    "-" => a - b,
    "/" => a / Convert.ToDouble(b),
    "*" => a * b,
    "^" => Math.Pow(a, b),
    _ => "Nincs ilyen operátor!"
});
#endregion

#region 8.feladat
Console.Write("\nAdjon meg egy összeget: ");
double amount = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"Készpénzben fizetendő összeg: {(Math.Round(amount / 5) * 5):C0}");
#endregion

#region 9.feladat
Console.Write("\nAdjon meg egy évszámot: ");
int year = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg egy hónap nevét");
Console.WriteLine((Console.ReadLine() ?? "").ToLower() switch
{
    "január" => "31",
    "február" => year % 4 == 0 && year % 100 != 0 ? "29" : "28",
    "március" => "31",
    "április" => "30",
    "május" => "31",
    "június" => "30",
    "július" => "31",
    "augusztus" => "31",
    "szeptember" => "30",
    "október" => "31",
    "november" => "30",
    "december" => "31",
    _ => "Nincs ilyen hónap!"
});
#endregion

#region 10.feladat
Console.Write("\nAdja meg a vásárlás összegét: ");
int spentAmount = int.Parse(Console.ReadLine() ?? "");
string? gift = spentAmount switch
{
    > 10000 => "zsákbamacska",
    > 6000 => "tábla csoki",
    > 3000 => "gumicukor",
    _ => null
};

if (gift == "zsákbamacska")
    gift = new string[] { "pohárkrém", "kandírozott gyümölcs", "marcipán figura" }[Random.Shared.Next(3)];

if (gift == "pohárkrém")
    gift = new string[] { "csokoládé", "vanília", "mogyoró", "puncs" }[Random.Shared.Next(4)] + " ízű pohárkrém";

Console.WriteLine($"A vásárlás összege: {spentAmount}, " +
    $"ezért {spentAmount / 500} db nyereményszelvény, " +
    $"illetve {(gift is null ? "nem jár ajándék" : $"egy ajándék {gift} jár")}.");
#endregion

#region 11.feladat
Console.Write("\nAdja meg az időt (óra:perc): ");
int hour = int.Parse((Console.ReadLine() ?? "").Split(':')[0]);

if (hour is >= 6 and < 21)
{
    Console.Write("Elegendő fény szűrődik be (i/n)? ");
    Console.WriteLine((Console.ReadLine() ?? "") switch
    {
        "i" => "A lámpa nem világít.",
        "n" => "A lámpa nappali fénnyel világít.",
        _ => "Csak igennel vagy nemmel válaszolhat!",
    });
}
else Console.WriteLine("A lámpa éjszakai fénnyel világít.");
#endregion

#region 12.feldat
int[] card = { Random.Shared.Next(1, 10), Random.Shared.Next(10), Random.Shared.Next(10), Random.Shared.Next(10) };

bool firstRoom = card[0] > 4;
bool secondRoom = card[1] > 4;
bool thirdRoom = card[2] > 4;
bool fourthRoom = card[3] > 4;
bool fifthRoom = card[0] % 2 == 0 && card[2] % 2 == 0;
bool sixthRoom = card[1] % 2 == 0 && card[3] % 2 == 0;
bool seventhRoom = card[0] > 4
    && card[1] > 4
    && card[2] > 4
    && card[3] > 4
    && card[0] % 2 == 0
    && card[1] % 2 == 0
    && card[2] % 2 == 0
    && card[3] % 2 == 0
    && !(card[0] == card[1] && card[1] == card[2] && card[2] == card[3]);

Console.Write($"\nA generált kód a {string.Join("", card)}:");

if (!(firstRoom || secondRoom || thirdRoom || fourthRoom || fifthRoom || sixthRoom || seventhRoom))
    Console.WriteLine(" A kód érvénytelen!");
else
    Console.WriteLine($"\n\t- 1. helyiségbe: {(firstRoom ? "beléphet" : "nem léphet be")}" +
    $"\n\t- 2. helyiségbe: {(secondRoom ? "beléphet" : "nem léphet be")}" +
    $"\n\t- 3. helyiségbe: {(thirdRoom ? "beléphet" : "nem léphet be")}" +
    $"\n\t- 4. helyiségbe: {(fourthRoom ? "beléphet" : "nem léphet be")}" +
    $"\n\t- 5. helyiségbe: {(fifthRoom ? "beléphet" : "nem léphet be")}" +
    $"\n\t- 6. helyiségbe: {(sixthRoom ? "beléphet" : "nem léphet be")}" +
    $"\n\t- 7. helyiségbe: {(seventhRoom ? "beléphet" : "nem léphet be")}");
#endregion