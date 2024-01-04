#region a.
int[] numbers = ReadData();
#endregion

#region b.
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i + 1}. szám: {numbers[i]}");
}
#endregion

#region c.
Console.WriteLine($"\n{string.Join("\t", numbers)}");
#endregion

#region d.
WriteNumbersInPairsToFile();
#endregion

#region e.
double sum = SumOfNumbers();
Console.WriteLine($"\nA számok összege: {sum}");
#endregion

#region f.
Console.WriteLine($"A számok átlaga: {sum / numbers.Length}");
#endregion

#region g.
Console.WriteLine($"A számok maximuma: {MaxOfNumbers()}");
#endregion

#region h.
Console.WriteLine($"A számok minimuma: {MinOfNumbers()}");
#endregion

#region i.
Console.WriteLine($"A számok között {(ContainsZero() ? "van" : "nincs")} nulla.");
#endregion

#region j.
if (FirstNegative(out int index))
    Console.WriteLine($"Az első negaív szám a {index}. helyen áll.");
else
    Console.WriteLine("Nincs negatív szám a számok között.");
#endregion

#region k.
Console.WriteLine($"A számok {PositivePercent():P2} pozitív.");
#endregion

static int[] ReadData()
{
    Console.Write("Adja meg a beolvasandó fájl nevét: ");
    var input = new StreamReader(Console.ReadLine() ?? "");
    int length = int.Parse(input.ReadLine() ?? "");
    int[] numbers = new int[length];

    for (int i = 0; i < length; i++)
    {
        numbers[i] = int.Parse(input.ReadLine() ?? "");
        Console.WriteLine($"{i + 1}. szám: {numbers[i]}");
    }

    input.Close();

    return numbers;
}

void WriteNumbersInPairsToFile()
{
    var output = new StreamWriter("parosaval.txt");

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int a = numbers[i];
        int b = numbers[i + 1];
        output.WriteLine($"{a};{b};{((a + b) / 2.0):N2}");
    }

    output.Close();
}

int SumOfNumbers()
{
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum;
}

int MaxOfNumbers()
{
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }

    return max;
}

int MinOfNumbers()
{
    int min = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min) min = numbers[i];
    }

    return min;
}

bool ContainsZero()
{
    int i = 0;

    while (i < numbers.Length && numbers[i] != 0)
    {
        i++;
    }

    return i < numbers.Length;
}

bool FirstNegative(out int index)
{
    index = 0;

    while (index < numbers.Length && numbers[index] != 0)
    {
        index++;
    }

    return index < numbers.Length;
}

double PositivePercent()
{
    double countOfPositive = 0;

    foreach (int number in numbers)
    {
        if (number > 0) countOfPositive++;
    }

    return countOfPositive / numbers.Length;
}