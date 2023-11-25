#region 1. feladat
Console.WriteLine("Termékek egységára:" +
    "\n\t- alma 240 Ft/kg" +
    "\n\t- szilva 310 Ft/kg" +
    "\n\t- szőlő 650 Ft/kg");

Console.Write("\nAdja meg, hogy hány kg almát vásárolt: ");
double appleKg = double.Parse(Console.ReadLine() ?? "");
double apple = appleKg * 240;

Console.Write("Adja meg, hogy hány kg szilvát vásárolt: ");
double plumKg = double.Parse(Console.ReadLine() ?? "");
double plum = plumKg * 310;

Console.Write("Adja meg, hogy hány kg szőlőt vásárolt: ");
double grapeKg = double.Parse(Console.ReadLine() ?? "");
double grape = grapeKg * 650;

Console.WriteLine($"\nÖsszesen: {apple + plum + grape:C0}" +
    $"\n\t- {appleKg} kg alma - {apple:C0}" +
    $"\n\t- {plumKg} kg szilva - {plum:C0}" +
    $"\n\t- {grapeKg} kg szőlő - {grape:C0}");
#endregion

#region 2. feladat
Console.Write("\nAdja meg a napi bevételét: ");
int income = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A mai jutalma: {income * 0.05:C0}");
#endregion

#region 3. feladat
Console.Write("\nAdja meg, hogy hány fő választota a színházat: ");
int theatreCount = int.Parse(Console.ReadLine() ?? "");
int theatre = theatreCount * 2500;

Console.Write("Adja meg, hogy hány fő választota a komolyzenei koncertet: ");
int classicalMusicCount = int.Parse(Console.ReadLine() ?? "");
int classicalMusic = classicalMusicCount * 2200;

Console.Write("Adja meg, hogy hány fő választota a népzenei koncertet: ");
int folkMusicCount = int.Parse(Console.ReadLine() ?? "");
int folkMusic = folkMusicCount * 2400;

Console.WriteLine($"\nÖsszesen: {theatre + classicalMusic + folkMusic:C0}" +
    $"\n\t- {theatreCount} fő színház - {theatre:C0}" +
    $"\n\t- {classicalMusicCount} fő komolyzenei koncert - {classicalMusic:C0}" +
    $"\n\t- {folkMusicCount} fő népzenei koncertet - {folkMusic:C0}");
#endregion

#region 4. feladat
Console.Write("\nAdja meg, hogy hanyadika van: ");
int day = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg, hogy hány óra van: ");
int hour = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{((day - 1) * 24) + hour} óra telt el a hónapból.");
#endregion

#region 5. feladat
Console.WriteLine(Exercise5());
#endregion

#region 6. feladat
Console.Write("\nAdja meg a maximálisan elérhető pontszámot: ");
double max = double.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az ön által elért pontot: ");
double scoredPoints = double.Parse(Console.ReadLine() ?? "");

if (scoredPoints > max)
    Console.WriteLine("Nem megfelelő adatok.");
else if (scoredPoints >= max * 0.85)
    Console.WriteLine("Jól dolgoztál, ötös a dolgozatod. Ügyes vagy.");
else
    Console.WriteLine("Ezt a témakört még gyakorolni kell.");
#endregion

#region 7. feladat
Console.Write("\nAdja meg, hogy hány óra, hány perckor feküdt le (óra:perc): ");
string[] start = (Console.ReadLine() ?? "").Split(':');
int startHour = int.Parse(start[0]);
int startMinute = int.Parse(start[1]);

Console.Write("Adja meg, hogy hány óra, hány perckor kelt fel (óra:perc): ");
string[] end = (Console.ReadLine() ?? "").Split(':');
int endHour = int.Parse(end[0]);
int endMinute = int.Parse(end[1]);

int sleepHour = startHour <= endHour ? endHour - startHour : 24 - startHour + endHour;
int sleepMinute = endMinute - startMinute;

if (sleepMinute < 0)
{
    sleepHour -= 1;
    sleepMinute += 60;
}

Console.WriteLine($"Alvási idő: {sleepHour} óra {sleepMinute} perc.");

int sleepDurationInMinutes = sleepHour * 60 + sleepMinute;

if (sleepDurationInMinutes < 7 * 60)
    Console.WriteLine("Túl keveset aludtál.");
else if (sleepDurationInMinutes < 9 * 60)
    Console.WriteLine("Megfelelő alvásmennyiség.");
else
    Console.WriteLine("Túl sokat aludtál.");
#endregion


static string Exercise5()
{
    Console.Write("\nAdja meg, hogy hány óra van: ");
    int hour = int.Parse(Console.ReadLine() ?? "");
    if (hour is not > 0 and <= 23)
        return "Az órának 0 és 23 között kell lennie!";

    Console.Write("Adja meg a percet: ");
    int minute = int.Parse(Console.ReadLine() ?? "");
    if (minute is not > 0 and <= 59)
        return "Az percnek 0 és 59 között kell lennie!";

    Console.Write("Adja meg a másodpercet: ");
    int second = int.Parse(Console.ReadLine() ?? "");
    if (second is not > 0 and <= 59)
        return "Az másodpercnek 0 és 59 között kell lennie!";

    return $"A nap {hour + 1}. órájában vagyunk.";
}