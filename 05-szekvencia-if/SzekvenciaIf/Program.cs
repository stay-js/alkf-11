//1. feladat
Console.WriteLine("Termékek egységára:" +
    "\n\t- alma 240 Ft/kg" +
    "\n\t- szilva 310 Ft/kg" +
    "\n\t- szőlő 650 Ft/kg");
Console.Write("Adja meg, hogy hány kg almát vásárolt: ");
float appleKg = Convert.ToSingle(Console.ReadLine());
float apple = appleKg * 240;

Console.Write("Adja meg, hogy hány kg szilvát vásárolt: ");
float plumKg = Convert.ToSingle(Console.ReadLine());
float plum = plumKg * 310;

Console.Write("Adja meg, hogy hány kg szőlőt vásárolt: ");
float grapeKg = Convert.ToSingle(Console.ReadLine());
float grape = grapeKg * 650;

Console.WriteLine($"- {appleKg} kg alma - {apple:N0} Ft");
Console.WriteLine($"- {plumKg} kg szilva - {plum:N0} Ft");
Console.WriteLine($"- {grapeKg} kg szőlő - {grape:N0} Ft");
Console.WriteLine($"Összesen: {(apple + plum + grape):N0} Ft");

//2. feladat
Console.Write("Adja meg a napi bevételét: ");
int income = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A mai jutalma: {(income * 0.05):N0}");

//3. feladat
Console.Write("Adja meg, hogy hány fő választota a színházat: ");
int theatreCount = Convert.ToInt32(Console.ReadLine());
int theatre = theatreCount * 2500;

Console.Write("Adja meg, hogy hány fő választota a komolyzenei koncertet: ");
int classicalMusicCount = Convert.ToInt32(Console.ReadLine());
int classicalMusic = classicalMusicCount * 2200;

Console.Write("Adja meg, hogy hány fő választota a népzenei koncertet: ");
int folkMusicCount = Convert.ToInt32(Console.ReadLine());
int folkMusic = folkMusicCount * 2400;

Console.WriteLine($"- {theatreCount} fő színház - {theatre:N0} Ft");
Console.WriteLine($"- {classicalMusicCount} fő komolyzenei koncert - {classicalMusic:N0} Ft");
Console.WriteLine($"- {folkMusicCount} fő népzenei koncertet - {folkMusic:N0} Ft");
Console.WriteLine($"Összesen: {(theatre + classicalMusic + folkMusic):N0} Ft");

//4. feladat
Console.Write("Adja meg, hogy hanyadika van: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg, hogy hány óra van: ");
int hour = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{((day - 1) * 24) + hour} óra telt el a hónapból.");

//5. feladat
Console.Write("Adja meg, hogy hány óra van: ");
int hour1 = Convert.ToInt32(Console.ReadLine());
if (hour1 < 0 || hour1 >= 24)
    throw new Exception("Az órának 0 és 23 között kell lennie!");

Console.Write("Adja meg a percet: ");
int minute = Convert.ToInt32(Console.ReadLine());
if (minute < 0 || minute >= 60)
    throw new Exception("Az percnek 0 és 59 között kell lennie!");

Console.Write("Adja meg a másodpercet: ");
int second = Convert.ToInt32(Console.ReadLine());
if (second < 0 || second >= 60)
    throw new Exception("Az másodpercnek 0 és 59 között kell lennie!");

Console.WriteLine($"A nap {hour1 + 1}. órájában vagyunk.");

//6. feladat
Console.Write("Adja meg a maximálisan elérhető pontszámot: ");
float max = Convert.ToSingle(Console.ReadLine());

Console.Write("Adja meg az ön által elért pontot: ");
float scoredPoints = Convert.ToSingle(Console.ReadLine());

if (scoredPoints > max)
    throw new Exception("Nem megfelelő adatok.");

if (scoredPoints >= max * 0.85)
    Console.WriteLine("Jól dolgoztál, ötös a dolgozatod. Ügyes vagy.");
else
    Console.WriteLine("Ezt a témakört még gyakorolni kell.");

//7. feladat
Console.Write("Adja meg, hogy hány órakor feküdt le: ");
int startHour = Convert.ToInt32(Console.ReadLine());
Console.Write($"Adja meg, hogy {startHour} óra hány perckor feküdt le: ");
int startMinute = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg, hogy hány órakor kelt fel: ");
int endHour = Convert.ToInt32(Console.ReadLine());
Console.Write($"Adja meg, hogy {endHour} óra hány perckor kelt fel: ");
int endMinute = Convert.ToInt32(Console.ReadLine());

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