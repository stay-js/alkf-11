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
WriteNumbersInPairsToFile(numbers);
#endregion

#region e.
double sum = SumOfNumbers(numbers);
Console.WriteLine($"\nA számok összege: {sum}");
#endregion

#region f.
Console.WriteLine($"A számok átlaga: {sum / numbers.Length}");
#endregion

#region g.
Console.WriteLine($"A számok maximuma: {MaxOfNumbers(numbers)}");
#endregion

#region h.
Console.WriteLine($"A számok minimuma: {MinOfNumbers(numbers)}");
#endregion

#region i.
Console.WriteLine($"A számok között {(ContainsZero(numbers) ? "van" : "nincs")} nulla.");
#endregion

#region j.
if (FirstNegative(numbers, out int index))
    Console.WriteLine($"Az első negaív szám a {index}. helyen áll.");
else
    Console.WriteLine("Nincs negatív szám a számok között.");
#endregion

#region k.
Console.WriteLine($"A számok {PositivePercent(numbers):P2} pozitív.");
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

static void WriteNumbersInPairsToFile(int[] numbers)
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

static int SumOfNumbers(int[] numbers)
{
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum;
}

static int MaxOfNumbers(int[] numbers)
{
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }

    return max;
}

static int MinOfNumbers(int[] numbers)
{
    int min = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min) min = numbers[i];
    }

    return min;
}

static bool ContainsZero(int[] numbers)
{
    int i = 0;

    while (i < numbers.Length && numbers[i] != 0)
    {
        i++;
    }

    return i < numbers.Length;
}

static bool FirstNegative(int[] numbers, out int index)
{
    index = 0;

    while (index < numbers.Length && numbers[index] != 0)
    {
        index++;
    }

    return index < numbers.Length;
}

static double PositivePercent(int[] numbers)
{
    double countOfPositive = 0;

    foreach (int number in numbers)
    {
        if (number > 0) countOfPositive++;
    }

    return countOfPositive / numbers.Length;
}