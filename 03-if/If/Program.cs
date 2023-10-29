var random = new Random();

#region 1. feladat
Console.Write("Adja meg a téglalap egyik oldalát: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a téglalap másik oldalát: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > 0 && b > 0)
{
    Console.WriteLine($"A téglalap kerülete: {2 * (a + b)}");
    Console.WriteLine($"A téglalap területe: {a * b}");
}
else Console.Write("A megadott adatok nem megfelelőek!");
#endregion


#region 2. feladat
Console.Write("\nAdjon meg egy valós számot: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Adjon meg egy valós számot: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A két szám összege: {x + y}");
Console.WriteLine($"A két szám különbsége: {x - y}");
Console.WriteLine($"A két szám szorzata: {x * y}");

if (y != 0) Console.WriteLine($"A két szám különbsége: {x / y}");
else Console.WriteLine("Az osztó nem lehet nulla!");
#endregion

#region 3. feladat
Console.Write("\nAdja meg a nevét: ");
string name = Console.ReadLine()!;

Console.Write("Adja meg a születési évét: ");
int birthYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{(birthYear < 2000 ? "Jó napot" : "Szia")} {name}!");
#endregion

#region 4. feladat
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.Write("Adja meg az ajándék árát: ");
    int price = Convert.ToInt32(Console.ReadLine());

    if (price == 20_000)
        Console.WriteLine("Az ajándék pontosan 20 000 Ft-ba került.");
    else if (price < 20_000)
        Console.WriteLine($"Az ajándék {(20_000 - price):C0}-al a limit alatt van.");
    else
        Console.WriteLine($"Az ajándék {(price - 20_000):C0}-al lépte túl a limitet.");
}
#endregion

#region 5. feladat
Console.WriteLine(random.Next(2) == 0 ? "\nfej" : "\nírás");
#endregion

#region 6.feladat
Console.Write("\nAdojon meg egy számot: ");
Console.WriteLine($"A szám {(
    Convert.ToInt32(Console.ReadLine()) % 2 == 0
    ? "páros" : "páratlan"
    )}.");
#endregion

#region 7. feladat
Console.Write("\nSzeretne ötöst kapni programozásból? ");
Console.WriteLine(Console.ReadLine() switch
{
    "igen" => "Akkor gyakorolj!",
    "nem" => "Helytelen a hozzáállásod!",
    _ => "Csak igennel és nemmel válaszolhat!"
});
#endregion

#region 8. feladat
Console.Write("\nAdjon meg egy számot: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
    Console.WriteLine("A megadott szám nulla.");
else if (number > 0)
    Console.WriteLine("A megadott szám pozitív.");
else
    Console.WriteLine("A megadott szám negatív.");
#endregion

#region 9. feladat
Console.Write("\nAdja meg egy hónap sorszámát: ");
Console.WriteLine(Convert.ToInt32(Console.ReadLine()) switch
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

#region 10. feladat
Console.Write("\nAdjon meg egy évszámot: ");
int year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
    Console.WriteLine("A megadott év szökőév.");
else
    Console.WriteLine("A megadott év nem szökőév.");
#endregion

#region 11. feladat
Console.WriteLine();

var numbers = new List<int>();

for (int i = 0; i < 3; i++)
{
    Console.Write("Adjon meg egy számot: ");
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}

numbers.Sort();

Console.WriteLine($"A legnagyobb megadott szám a {numbers[^1]}");
#endregion

#region 12. feladat
Console.Write("\nAdja meg a termék árát: ");
int fullPrice = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a leárazás mértékét: ");
double discountRate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A terméket {(discountRate > 50 ? "megéri" : "nem éri meg")} megvenni." +
    $"\nA termék kedvezményes ára: {(fullPrice * 1 - (discountRate / 100)):C0}");
#endregion

#region 13. feladat
Console.Write("\nAdja meg a víz hőmérsékletét: ");
int temperature = Convert.ToInt32(Console.ReadLine());

if (temperature < 0)
    Console.WriteLine("Szilárd halmazállapotú.");
else if (temperature < 100)
    Console.WriteLine("Folyékony halmazállapotú.");
else
    Console.WriteLine("Gáz halmazállapotú.");
#endregion

#region 14. feladat
Console.WriteLine();

var numbers1 = new List<int>();

for (int i = 0; i < 3; i++)
{
    Console.Write("Adjon meg egy számot: ");
    numbers1.Add(Convert.ToInt32(Console.ReadLine()));
}

numbers1.Sort();

Console.WriteLine(string.Join(", ", numbers1));
#endregion

#region 15. feladat
Console.Write("\nAdja meg a génpár első elemét: ");
string firstGene = Console.ReadLine() ?? "";

Console.Write("Adja meg a génpár második elemét: ");
string secondGene = Console.ReadLine() ?? "";

string[] valid = { "A", "B", "0" };

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