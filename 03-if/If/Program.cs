#region 1. feladat
Console.Write("Adja meg a téglalap egyik oldalát: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg a téglalap másik oldalát: ");
int b = int.Parse(Console.ReadLine() ?? "");

if (a > 0 && b > 0)
{
    Console.WriteLine($"A téglalap kerülete: {2 * (a + b)}");
    Console.WriteLine($"A téglalap területe: {a * b}");
}
else Console.Write("A megadott adatok nem megfelelőek!");
#endregion


#region 2. feladat
Console.Write("\nAdjon meg egy valós számot: ");
double x = double.Parse(Console.ReadLine() ?? "");

Console.Write("Adjon meg egy valós számot: ");
double y = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A két szám összege: {x + y}");
Console.WriteLine($"A két szám különbsége: {x - y}");
Console.WriteLine($"A két szám szorzata: {x * y}");

Console.WriteLine(y != 0 ? $"A két szám hányadosa: {x / y}" : "Az osztó nem lehet nulla!");
#endregion

#region 3. feladat
Console.Write("\nAdja meg a nevét: ");
string name = Console.ReadLine() ?? "";

Console.Write("Adja meg a születési évét: ");
int birthYear = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{(birthYear < 2000 ? "Jó napot" : "Szia")} {name}!");
#endregion

#region 4. feladat
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.Write("Adja meg az ajándék árát: ");
    int price = int.Parse(Console.ReadLine() ?? "");

    if (price == 20_000)
        Console.WriteLine("Az ajándék pontosan 20 000 Ft-ba került.");
    else if (price < 20_000)
        Console.WriteLine($"Az ajándék {20_000 - price:C0}-al a limit alatt van.");
    else
        Console.WriteLine($"Az ajándék {price - 20_000:C0}-al lépte túl a limitet.");
}
#endregion

#region 5. feladat
Console.WriteLine(Random.Shared.Next(2) == 0 ? "\nfej" : "\nírás");
#endregion

#region 6.feladat
Console.Write("\nAdojon meg egy számot: ");
Console.WriteLine($"A szám " +
    $"{(int.Parse(Console.ReadLine() ?? "") % 2 == 0? "páros" : "páratlan")}.");
#endregion

#region 7. feladat
Console.Write("\nSzeretnél ötöst kapni programozásból? ");
string answer = Console.ReadLine() ?? "";

if (answer == "igen") Console.WriteLine("Akkor gyakorolj!");
else if (answer == "nem") Console.WriteLine("Helytelen a hozzáállásod!");
else Console.WriteLine("Csak igennel és nemmel válaszolhatsz!");
#endregion

#region 8. feladat
Console.Write("\nAdjon meg egy számot: ");
double number = double.Parse(Console.ReadLine() ?? "");

if (number == 0) Console.WriteLine("A megadott szám nulla.");
else if (number < 0) Console.WriteLine("A megadott szám negatív.");
else Console.WriteLine("A megadott szám pozitív.");
#endregion

#region 9. feladat
Console.Write("\nAdja meg egy hónap sorszámát: ");
int monthAsInt = int.Parse(Console.ReadLine() ?? "");

if (monthAsInt is < 0 or > 12) Console.WriteLine("Nincs ilyen hónap.");
else if (monthAsInt is <= 2 or 12) Console.WriteLine("Tél");
else if (monthAsInt <= 5) Console.WriteLine("Tavasz");
else if (monthAsInt <= 8) Console.WriteLine("Nyár");
else if (monthAsInt <= 11) Console.WriteLine("Ősz");
#endregion

#region 10. feladat
Console.Write("\nAdjon meg egy évszámot: ");
int year = int.Parse(Console.ReadLine() ?? "");

if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
    Console.WriteLine("A megadott év szökőév.");
else
    Console.WriteLine("A megadott év nem szökőév.");
#endregion

#region 11. feladat
Console.WriteLine($"A legnagyobb megadott szám a {threeSortedNumbres()[^1]}");
#endregion

#region 12. feladat
Console.Write("\nAdja meg a termék árát: ");
int fullPrice = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg a leárazás mértékét: ");
double discountRate = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A terméket {(discountRate > 50 ? "megéri" : "nem éri meg")} megvenni." +
    $"\nA termék kedvezményes ára: {fullPrice * 1 - (discountRate / 100):C0}.");
#endregion

#region 13. feladat
Console.Write("\nAdja meg a víz hőmérsékletét (°C): ");
double temperature = double.Parse(Console.ReadLine() ?? "");

if (temperature < 0) Console.WriteLine("Szilárd halmazállapotú.");
else if (temperature < 100) Console.WriteLine("Folyékony halmazállapotú.");
else Console.WriteLine("Gáz halmazállapotú.");
#endregion

#region 14. feladat
Console.WriteLine(string.Join(", ", threeSortedNumbres()));
#endregion

#region 15. feladat
Console.Write("\nAdja meg a génpár első elemét: ");
string firstGene = Console.ReadLine() ?? "";

Console.Write("Adja meg a génpár második elemét: ");
string secondGene = Console.ReadLine() ?? "";

string[] valid = ["A", "B", "0"];

if (!valid.Contains(firstGene) || !valid.Contains(secondGene))
    Console.WriteLine("A megadott génpár nem létezik!");
else if (firstGene == "0" && secondGene == "0")
    Console.WriteLine("0");
else if (firstGene == "0" && secondGene == "A")
    Console.WriteLine("A");
else if (firstGene == "0" && secondGene == "B")
    Console.WriteLine("B");
else if (firstGene == "A" && (secondGene == "0" || secondGene == "A"))
    Console.WriteLine("A");
else if (firstGene == "B" && (secondGene == "0" || secondGene == "B"))
    Console.WriteLine("B");
else
    Console.WriteLine("AB");
#endregion


static int[] threeSortedNumbres()
{
    Console.WriteLine();

    int[] numbers = new int[3];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("Adjon meg egy számot: ");
        numbers[i] = int.Parse(Console.ReadLine() ?? "");
    }

    Array.Sort(numbers);

    return numbers;
}