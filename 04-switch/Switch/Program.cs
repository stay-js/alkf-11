// 1. feladat
Console.Write("Adjon meg egy érdemjegyet: ");
int grade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(grade switch
{
    1 => "Elégtelen",
    2 => "Elégséges",
    3 => "Közepes",
    4 => "Jó",
    5 => "Jeles",
    _ => "Nincs ilyen érdemjegy!"
});

// 2.feladat
Console.Write("Adja meg egy hónap nevét: ");
switch (Console.ReadLine())
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

// 3.feladat
Console.Write("Adja meg egy hónap sorszámát: ");
int monthAsInt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(monthAsInt switch
{
    < 1 => "Nincs ilyen hónap",
    <= 2 => "Tél",
    <= 5 => "Tavasz",
    <= 8 => "Nyár",
    <= 11 => "Ősz",
    12 => "Tél",
    _ => "Nincs ilyen hónap"
});

// 4.feladat
Console.Write("Adja meg, hogy átlagosan hány órát alszik naponta: ");
int sleepHours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sleepHours switch
{
    < 0 => "Csak természetes számot adhat meg!",
    <= 6 => "Kevés",
    <= 9 => "Átlagos",
    <= 12 => "Sok",
    <= 24 => "Nagyon sok",
    _ => "Egy nap 24 órából áll!"
});

//5. feladat
Console.Write("Adjon megy egy szeptemberi napot: ");
int day = Convert.ToInt32(Console.ReadLine());
DateTime dateValue = new DateTime(2023, 09, day);
Console.WriteLine(dateValue.DayOfWeek switch
{
    DayOfWeek.Monday => "Matek, Töri, Angol, Német, Irodalom, Tesi",
    DayOfWeek.Tuesday => "Webprogramozás, IKT",
    DayOfWeek.Wednesday => "Matek, Fizika, Tesi, Töri, Nyelvtan, Szakmai Angol",
    DayOfWeek.Thursday => "Linux, Adatbázis, Asztali alkalmazás fejlesztés",
    DayOfWeek.Friday => "Fizika, Irodalom, Matematika, Osztályfőnöki, Angol, Német, Tesi, Digitális kultúra",
    _ => "Hétvége"
});

//6. feladat
Console.WriteLine("Biztos, hogy nem!");

//7. feladat
Console.Write("Adjon meg egy számot: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Adjon meg egy számot: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Adjon meg egy műveleti jelet: ");
string op = Console.ReadLine();
Console.WriteLine(op switch
{
    "+" => a + b,
    "-" => a - b,
    "/" => a / b,
    "*" => a * b,
    "^" => Math.Pow(a, b),
    _ => "Nincs ilyen operátor!"
});

//8.feladat
Console.Write("Adjon meg egy összeget: ");
string money = Console.ReadLine();
switch (money[^1])
{
    case '0':
    case '5':
        Console.WriteLine(money);
        break;
    case '1':
    case '2':
        Console.WriteLine(money[..^1] + 0);
        break;
    case '3':
    case '4':
    case '6':
    case '7':
        Console.WriteLine(money[..^1] + 5);
        break;
    case '8':
    case '9':
        Console.WriteLine();
        break;
}

//9.feladat
Console.Write("Adjon meg egy évszámot: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.Write("Adja meg egy hónap nevét");
switch (Console.ReadLine())
{
}