//1. feladat
Console.Write("Adja meg a téglalap egyik oldalát: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a téglalap másik oldalát: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a <= 0 || b <= 0)
    throw new Exception("A megadott adatok nem megfelelőek!");

Console.WriteLine($"A téglalap kerülete: {2 * (a + b)}");
Console.WriteLine($"A téglalap területe: {a * b}");


//2. feladat
Console.Write("Adjon meg egy valós számot: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Adjon meg egy valós számot: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A két szám összege: {num + num1}");
Console.WriteLine($"A két szám különbsége: {num - num1}");
Console.WriteLine($"A két szám szorzata: {num * num1}");

if (num1 == 0)
    throw new Exception("Az osztó nem lehet nulla!");

Console.WriteLine($"A két szám különbsége: {num / num1}");

//3. feladat
Console.Write("Adja meg a nevét: ");
string name = Console.ReadLine()!;

Console.Write("Adja meg a születési évét: ");
int birthYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{(birthYear < 2000 ? "Jó napot" : "Szia")} {name}!");

//4. feladat
for (int i = 0; i < 3; i++)
{
    Console.Write("Adja meg az ajándék árát: ");
    int price = Convert.ToInt32(Console.ReadLine());

    if (price == 20_000)
        Console.WriteLine("Az ajándék pontosan 20 000 Ft-ba került.");
    else if (price < 20_000)
        Console.WriteLine($"Az ajándék {(20_000 - price):N0} Ft-al a limit alatt van.");
    else
        Console.WriteLine($"Az ajándék {(price - 20_000):N0} Ft-al lépte túl a limitet.");
}

//5. feladat
Random random = new Random();
Console.WriteLine(random.Next(2) == 0 ? "fej" : "írás");

//6.feladat
Console.Write("Adojon meg egy számot: ");
Console.WriteLine($"A szám {(
    Convert.ToInt32(Console.ReadLine()) % 2 == 0
    ? "páros" : "páratlan"
    )}.");

//7. feladat
Console.WriteLine("Szeretne ötöst kapni programozásból?");
string answer = Console.ReadLine() ?? "";

if (answer == "igen")
    Console.WriteLine("Akkor gyakorolj!");
else if (answer == "nem")
    Console.WriteLine("Helytelen a hozzáállásod!");
else
    throw new Exception("Csak igennel és nemmel válaszolhat!");

//8. feladat
Console.Write("Adjon meg egy számot: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
    Console.WriteLine("A megadott szám nulla.");
else if (number > 0)
    Console.WriteLine("A megadott szám pozitív.");
else
    Console.WriteLine("A megadott szám negatív.");

//9. feladat
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

//10. feladat
Console.WriteLine("Adjon meg egy évszámot: ");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
    Console.WriteLine("A megadott év szökőév.");
else
    Console.WriteLine("A megadott év nem szökőév.");

//11. feladat
var numbers = new List<int>();

for (int i = 0; i < 3; i++)
{
    Console.Write("Adjon meg egy számot: ");
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}

numbers.Sort();

Console.WriteLine($"A legnagyobb megadott szám a {numbers[^1]}");

//12. feladat
Console.Write("Adja meg a termék árát: ");
int fullPrice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Adja meg a leárazás mértékét: ");
int discountRate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A terméket {(discountRate > 50 ? "megéri" : "nem éri meg")} megvenni." +
    $"\nA termék kedvezményes ára: {(fullPrice * discountRate / 100):N0}Ft");

//13. feladat
Console.Write("Adja meg a víz hőmérsékletét: ");
int temperature = Convert.ToInt32(Console.ReadLine());

if (temperature < 0)
    Console.WriteLine("Szilárd halmazállapotú.");
else if (temperature < 100)
    Console.WriteLine("Folyékony halmazállapotú.");
else
    Console.WriteLine("Gáz halmazállapotú.");

//14. feladat
var numbers1 = new List<int>();

for (int i = 0; i < 3; i++)
{
    Console.Write("Adjon meg egy számot: ");
    numbers1.Add(Convert.ToInt32(Console.ReadLine()));
}

numbers1.Sort();

Console.WriteLine(String.Join(", ", numbers1));

//15. feladat
Console.Write("Adja meg a génpár első elemét: ");
string firstGene = Console.ReadLine() ?? "";

Console.Write("Adja meg a génpár második elemét: ");
string secontGene = Console.ReadLine() ?? "";

string[] valid = { "A", "B", "0" };

if (!valid.Contains(firstGene) || !valid.Contains(firstGene))
    throw new Exception("A megadott génpár nem létezik!");

if (firstGene == "0" && secontGene == "0")
    Console.WriteLine("0");
else if (firstGene == "0" && secontGene == "A")
    Console.WriteLine("A");
else if (firstGene == "0" && secontGene == "B")
    Console.WriteLine("B");
else if (firstGene == "A" && (secontGene == "0" || secontGene == "A"))
    Console.WriteLine("A");
else if (firstGene == "B" && (secontGene == "0" || secontGene == "B"))
    Console.WriteLine("B");
else
    Console.WriteLine("AB");