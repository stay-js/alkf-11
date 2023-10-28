Random random = new Random();

#region 1.feladat
Console.WriteLine("1. feladat");

Console.Write("Adja meg a körkúp sugarát (cm): ");
double radius = Convert.ToDouble(Console.ReadLine());

Console.Write("Adja meg a körkúp magasságát (cm): ");
double height = Convert.ToDouble(Console.ReadLine());

double radiusSquared = Math.Pow(radius, 2);
double heightSquared = Math.Pow(height, 2);

Console.WriteLine($"A körkúp térfogata: {(1.0 / 3.0 * Math.PI * radiusSquared * height):N2} cm3.");
Console.WriteLine($"A körkúp felszíne: {(
    (Math.PI * radiusSquared) +
    (Math.PI * radius * Math.Sqrt(radiusSquared + heightSquared))
    ):N2} cm2.");
#endregion

#region 2. feladat
Console.WriteLine("\n2. feladat");

Console.Write("Adja meg a sípálya legmeredekebb lejtőjét: ");
uint steepness = Convert.ToUInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

switch (steepness)
{
    case <= 12:
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("A pálya könnyű.");
        break;
    case <= 20:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A pálya középnehéz.");
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("A pálya nehéz.");
        break;
}

Console.ResetColor();
Console.Clear();
#endregion

#region 3. feladat
Console.WriteLine("\n3. feladat");

Console.WriteLine(random.Next(1, 7) switch
{
    1 => "1-et dobtál, kimaradsz a dobásból!",
    6 => "Lépj előre 6-ot, és újra dobhatsz!",
    int x => $"Lépj előre {x} mezőt!"
});
#endregion

#region 4. feladat
Console.WriteLine("\n4. feladat");

double number = random.NextDouble() * 200 - 100;
double floor = Math.Floor(number);
double math = Math.Round(number);
double ceil = Math.Ceiling(number);

Console.WriteLine($"A generált szám a {number}");
Console.WriteLine($"A szám {(
    number switch
    {
        < 0 => "negatív",
        0 => "nulla",
        _ => "pozitív"
    })}.");
Console.WriteLine($"Lefele kerekített értéke: {floor}");
Console.WriteLine($"Matematikai kerekített értéke: {math}");
Console.WriteLine($"Felfelé kerekített értéke: {ceil}");
Console.WriteLine($"A matematikai kerekítés a " +
    $"{(Convert.ToInt32(math) == Convert.ToInt32(floor) ? "lefele" : "felfele")}" +
    $" kerekített értékkel egyezik meg.");
Console.WriteLine($"A matematikai kerekítés {(math % 2 == 0 ? "páros" : "páratlan")}.");
#endregion