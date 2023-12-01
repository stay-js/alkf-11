using Local;

#region 1.feladat
var data = ReadData();
#endregion

#region 2.feladat
foreach (var item in data)
{
    Console.WriteLine($"{item.Location} - {item.SnacksCollected}");
}
#endregion

#region 3.feladat
Console.WriteLine($"\n{data.Length} nyomozáson vettek részt.");
#endregion

#region 4.feladat
Console.WriteLine($"Scooby-Doo átlagosan {AvgSnackCollected(data)} snacket gyűjtött össze.");
#endregion

#region 5.feladat
Console.WriteLine($"{CountLakeHeviz(data)} alkalommal nyomoztak a Hévízi-tónál.");
#endregion

#region 6.feladat
Console.WriteLine(data[MaxSnackCollected(data)].Location
    + " -nál/nél találta a legtöbb nyomot Scooby-Doo.");
#endregion

#region 7.feladat
Console.WriteLine((DidScoobyDooCollectedSpecifiedAmountOfSnacks(data) ? "Talált" : "Nem talált") +
    " Scooby-Doo pontosan a megadott mennyiségű snacket.");
#endregion

#region 8.feladat
Console.WriteLine(FindInvestigationByLocation(data, out int index)
    ? $"{data[index].SnacksCollected} snacket talált Scooby-Doo a megadott helyszínen."
    : "A megadott helyszín nem található.");
#endregion

#region 9.feladat
Console.WriteLine($"Páros gyűjtött snackek: {string.Join(", ", EvenSnacksFound(data))}");
#endregion

#region 10.feladat
WriteAtLeast50SnacksCollectedToFile(data);
#endregion

#region 11.feladat
(int[] dividable, int[] unDividable) = DividableAndUnDividableBy3(data);
Console.WriteLine($"\n3-mal osztható: {string.Join(", ", dividable)}");
Console.WriteLine($"3-mal nem osztható: {string.Join(", ", unDividable)}");
#endregion

static Investigation[] ReadData()
{
    return File.ReadLines("nyomozas.txt")
        .Select(line =>
        {
            string[] lineArr = line.Split();
            return new Investigation(string.Join(' ', lineArr[..^1]), int.Parse(lineArr[^1]));
        }).ToArray();
}

static double AvgSnackCollected(Investigation[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.SnacksCollected;
    }

    return sum / data.Length;
}

static int CountLakeHeviz(Investigation[] data)
{
    int count = 0;

    foreach (var item in data)
    {
        if (item.Location == "Hévízi-tó") count++;
    }

    return count;
}

static int MaxSnackCollected(Investigation[] data)
{
    int max = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].SnacksCollected > data[max].SnacksCollected) max = i;
    }

    return max;
}

static bool DidScoobyDooCollectedSpecifiedAmountOfSnacks(Investigation[] data)
{
    Console.Write("\nAdja meg a keresett értéket: ");
    int amount = int.Parse(Console.ReadLine() ?? "");

    int i = 0;

    while (i < data.Length && data[i].SnacksCollected != amount)
    {
        i++;
    }

    return i < data.Length;
}

static bool FindInvestigationByLocation(Investigation[] data, out int index)
{
    Console.Write("\nAdja meg a keresett helyszínt: ");
    string location = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Location.Equals(location, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}

static int[] EvenSnacksFound(Investigation[] data)
{
    //return data
    //    .Where(item => item.SnacksCollected % 2 == 0)
    //    .Select(item => item.SnacksCollected)
    //    .ToArray();

    int[] evenSnacks = new int[data.Length];
    int i = 0;

    foreach (var item in data.Where(item => item.SnacksCollected % 2 == 0))
    {
        evenSnacks[i++] = item.SnacksCollected;
    }

    int[] actualLength = new int[i];

    for (i = 0; i < actualLength.Length; i++)
    {
        actualLength[i] = evenSnacks[i];
    }

    return actualLength;
}

static void WriteAtLeast50SnacksCollectedToFile(Investigation[] data)
{
    var output = new StreamWriter("min-50-snack.txt");
    output.WriteLine(string.Join('\n',
        data.Where(item => item.SnacksCollected >= 50).Select(item => item.SnacksCollected)));
    output.Close();
}

static (int[], int[]) DividableAndUnDividableBy3(Investigation[] data)
{
    //int[] snacksCollected = data.Select(item => item.SnacksCollected).ToArray();

    //return (
    //    snacksCollected.Where(x => x % 3 == 0).ToArray(),
    //    snacksCollected.Where(x => x % 3 != 0).ToArray()
    //    );

    int[] dividable = new int[data.Length];
    int[] unDividable = new int[data.Length];
    int i = 0;
    int j = 0;

    foreach (int item in data.Select(item => item.SnacksCollected))
    {
        if (item % 3 == 0) dividable[i++] = item;
        else unDividable[j++] = item;
    }

    int[] actualLengthDividable = new int[i];

    for (i = 0; i < actualLengthDividable.Length; i++)
    {
        actualLengthDividable[i] = dividable[i];
    }

    int[] actualLengthUnDividable = new int[j];

    for (j = 0; j < actualLengthUnDividable.Length; j++)
    {
        actualLengthUnDividable[j] = unDividable[j];
    }

    return (actualLengthDividable, actualLengthUnDividable);
}

namespace Local
{
    public record Investigation(string Location, int SnacksCollected);
}