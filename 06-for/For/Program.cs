using System.Text;

#region 0.feladat
Console.Write("Adjon meg egy számot: ");
int n = int.Parse(Console.ReadLine() ?? "");
#endregion

#region 1. feladat
Console.WriteLine($"\nElső {n} szám növekvő sorrendben: ");

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
}
#endregion

#region 2. feladat
Console.WriteLine($"\nElső {n} négyzetszám: ");

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * i);
}
#endregion

#region 3. feladat
Console.WriteLine($"\nElső {n} szám csökkenő sorrendben: ");

for (int i = n; i > 0; i--)
{
    Console.WriteLine(i);
}
#endregion

#region 4. feladat
Console.WriteLine($"\nElső {n} páros szám: ");

for (int i = 2; i <= n * 2; i += 2)
{
    Console.WriteLine(i);
}
#endregion

#region 5. feladat
Console.Write("\nAdja meg az intervallum alsó határát: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az intervallum felső határát: ");
int max = int.Parse(Console.ReadLine() ?? "");

for (int i = min; i < max; i++)
{
    Console.WriteLine(i);
}
#endregion

#region 6. feladat
Console.Write("\nAdjon meg egy számot: ");
int number = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(number * i);
}
#endregion

#region 7. feladat
Console.Write("\nAdjon meg egy számot: ");
number = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i * number < 100; i++)
{
    Console.WriteLine(number * i);
}
#endregion

#region 8. feladat
Console.Write("\nAdjon meg egy számot: ");
uint uNumber = uint.Parse(Console.ReadLine() ?? "");

for (int i = 1; i < uNumber; i++)
{
    if (uNumber % i == 0) Console.WriteLine(i);
}
#endregion

#region 9. feladat
Console.Write("\nAdja meg a hatvány alapját: ");
int powerBase = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg a hatvány kitevőjét: ");
int powerExponent = int.Parse(Console.ReadLine() ?? "");

int power = 1;
for (int i = 1; i <= powerExponent; i++)
{
    power *= powerBase;
}

Console.WriteLine($"A hatvány értéke: {power}");
#endregion


#region 10.feladat
Console.Write("\nAdja meg az intervallum alsó határát: ");
min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az intervallum felső határát: ");
max = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adjon meg egy osztót: ");
int divisor = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"Az intervallumba eső {divisor}-val/vel osztható számok:");

for (int i = min; i <= max; i++)
{
    if (i % divisor == 0) Console.WriteLine(i);
}
#endregion

#region 11. feladat
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    Console.WriteLine(Random.Shared.Next(101));
}
#endregion


#region 12.feladat
Console.Write("\nAdja meg az intervallum alsó határát: ");
min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az intervallum felső határát: ");
max = int.Parse(Console.ReadLine() ?? "");

for (int i = 0; i < n; i++)
{
    Console.WriteLine(Random.Shared.NextDouble() * (max - min) + min);
}
#endregion

#region 13. feladat
Console.Write("\nAdjon meg egy számot: ");
int k = int.Parse(Console.ReadLine() ?? "");

for (int i = 0; i < k; i++)
{
    Console.WriteLine(Random.Shared.Next(2) == 0 ? "fej" : "írás");
}
#endregion

#region 14.feladat
Console.Write("\nAdjon meg egy számot: ");
k = int.Parse(Console.ReadLine() ?? "");

int sum = 0;
for (int i = 1; i <= k; i++)
{
    sum += i * (i + 1);
}
Console.WriteLine(sum);
#endregion

#region 15. feladat
Console.Write("\nAdjon meg egy számot: ");
k = int.Parse(Console.ReadLine() ?? "");

var toPrint = new StringBuilder();

for (int i = 0; i < k; i++)
{
    toPrint.Append('#');

    for (int j = 0; j < k - 2; j++)
    {
        toPrint.Append(i == 0 || i == k - 1 ? " #" : "  ");
    }

    toPrint.Append(" #\n");
}

Console.Write($"\n{toPrint}");
#endregion

#region 16.feladat
Console.Write("\nAdja meg a sorok számát: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az oszlopok számát: ");
int columns = int.Parse(Console.ReadLine() ?? "");

toPrint.Clear();

for (int i = 0; i < rows; i++)
{

    for (int j = 0; j < columns; j++)
    {
        if (i % 2 == 0)
            toPrint.Append(j % 2 == 0 ? 'X' : 'O');
        else
            toPrint.Append(j % 2 == 0 ? 'O' : 'X');
    }

    toPrint.AppendLine();
}

Console.Write($"\n{toPrint}");
#endregion

#region 17.feladat
Console.Write("\nAdjon meg egy számot: ");
k = int.Parse(Console.ReadLine() ?? "");

toPrint.Clear();

for (int i = 0; i < k; i++)
{
    for (int j = 0; j < k - 1 - i; j++)
    {
        toPrint.Append(' ');
    }

    for (int j = 0; j < (2 * i) + 1; j++)
    {
        toPrint.Append('*');
    }

    toPrint.AppendLine();
}

Console.Write($"\n{toPrint}");
#endregion

#region 18. feladat
Console.WriteLine("\nKét jegyű, hárommal oszható, nem páros számok:");

for (int i = -99; i < 100; i++)
{
    if (i % 2 != 0 && i % 3 == 0) Console.WriteLine(i);
}
#endregion

#region 19. feladat
Console.WriteLine();

for (int i = 1; i <= 14; i++)
{
    Console.WriteLine($"{i}. nap - {Random.Shared.Next(30, 121)} perc");
}
#endregion

#region 20. feladat
Console.WriteLine("\nHárom jegyű, Armstrong-számok:");

for (int i = 100; i <= 999; i++)
{
    int num = i;
    var digits = new List<int>();
    while (num > 0)
    {
        digits.Add(num % 10);
        num /= 10;
    }

    if (i == digits.Select(x => Math.Pow(x, 3)).Sum()) Console.WriteLine(i);
}
#endregion