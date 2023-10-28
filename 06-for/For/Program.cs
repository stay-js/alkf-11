Random random = new Random();

//0.feladat
Console.Write("Adjon meg egy számot: ");
int n = Convert.ToInt32(Console.ReadLine());

//1. feladat
Console.WriteLine($"\nElső {n} szám növekvő sorrendben: ");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
}

//2. feladat
Console.WriteLine($"\nElső {n} négyzetszám: ");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * i);
}

//3. feladat
Console.WriteLine($"\nElső {n} szám csökkenő sorrendben: ");
for (int i = n; i > 0; i--)
{
    Console.WriteLine(i);
}

//4. feladat
Console.WriteLine($"\nElső {n} páros szám: ");
for (int i = 2; i <= n * 2; i += 2)
{
    Console.WriteLine(i);
}

//5. feladat
Console.Write("\nAdja meg az intervallum minumum értékét: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az intervallum maximum értékét: ");
int max = Convert.ToInt32(Console.ReadLine());

for (int i = min; i < max; i++)
{
    Console.WriteLine(i);
}

//6. feladat
Console.Write("\nAdjon meg egy számot: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(number * i);
}

//7. feladat
Console.Write("\nAdjon meg egy számot: ");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i * number1 < 100; i++)
{
    Console.WriteLine(number1 * i);
}

//8. feladat
Console.Write("\nAdjon meg egy számot: ");
uint number2 = Convert.ToUInt32(Console.ReadLine());
for (int i = 1; i < number2; i++)
{
    if (number2 % i == 0)
        Console.WriteLine(i);
}

//9. feladat
Console.Write("\nAdja meg a hatvány alapját: ");
int powerBase = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a hatvány kitevőjét: ");
int powerExponent = Convert.ToInt32(Console.ReadLine());

int power = 1;
for (int i = 1; i <= powerExponent; i++)
{
    power *= powerBase;
}

Console.WriteLine($"A hatvány értéke: {power}");

//10.feladat

//11. feladat
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    Console.WriteLine(random.Next(101));
}


//12.feladat
Console.Write("\nAdja meg az intervallum minumum értékét: ");
int min2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az intervallum maximum értékét: ");
int max2 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(random.NextDouble() * (max2 - min2) + min2);
}

//13. feladat
Console.Write("\nAdjon meg egy számot: ");
int k = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    Console.WriteLine(random.Next(2) == 0 ? "fej" : "írás");
}

//14.feladat
Console.Write("\nAdjon meg egy számot: ");
int k1 = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= k1; i++)
{
    sum += i * (i + 1);
}
Console.WriteLine(sum);


string toPrint = "";

//15. feladat
Console.Write("\nAdjon meg egy számot: ");
int k2 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < k2; i++)
{
    toPrint = "";

    for (int j = 0; j < k2 - 2; j++)
    {
        toPrint += i == 0 || i == k2 - 1 ? "# " : "  ";
    }

    Console.WriteLine($"# {toPrint}#");
}

//16.feladat
Console.Write("\nAdja meg a sorok számát: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az oszlopok számát: ");
int columns = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < rows; i++)
{
    toPrint = "";

    for (int j = 0; j < columns; j++)
    {
        if (i % 2 == 0)
            toPrint += j % 2 == 0 ? 'X' : 'O';
        else
            toPrint += j % 2 == 0 ? 'O' : 'X';
    }

    Console.WriteLine(toPrint);
}

//17.feladat
Console.Write("\nAdjon meg egy számot: ");
int k3 = Convert.ToInt32(Console.ReadLine());

int sumOfLastRow = 1;

for (int i = 0; i < n - 1; i++)
{
    sumOfLastRow += 2;
}

toPrint = "";
int prev = 1;
int whiteSpace = sumOfLastRow - toPrint.Length / 2 - 2;

for (int j = 0; j < whiteSpace; j++)
{
    toPrint += " ";
}

Console.WriteLine(toPrint + "*");


for (int i = 1; i < n; i++, prev += 2)
{
    toPrint = "";
    whiteSpace = sumOfLastRow - toPrint.Length / 2 - (i + 2);

    for (int j = 0; j < whiteSpace; j++)
    {
        toPrint += " ";
    }

    for (int j = 0; j < prev + 2; j++)
    {
        toPrint += "*";
    }

    Console.WriteLine(toPrint);
}

//18. feladat
Console.WriteLine("\nKét jegyű, hárommal oszható, nem páros számok:");
for (int i = -99; i < 100; i++)
{
    if (i % 2 != 0 && i % 3 == 0)
        Console.WriteLine(i);
}

//19. feladat
Console.WriteLine();
for (int i = 1; i <= 14; i++)
{
    Console.WriteLine($"{i}. nap - {random.Next(30, 121)} perc");
}

//20. feladat
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

    double sum1 = 0;
    digits.ForEach(x => sum1 += Math.Pow(x, 3));

    if (sum1 == i)
        Console.WriteLine(i);

}