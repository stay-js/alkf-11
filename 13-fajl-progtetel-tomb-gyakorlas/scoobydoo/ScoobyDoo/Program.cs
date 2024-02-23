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
Console.WriteLine($"Scooby-Doo átlagosan {AvgSnackCollected()} snacket gyűjtött össze.");
#endregion

#region 5.feladat
Console.WriteLine($"{CountLakeHeviz()} alkalommal nyomoztak a Hévízi-tónál.");
#endregion

#region 6.feladat
Console.WriteLine(data[MaxSnackCollected()].Location
    + " -nál/nél találta a legtöbb nyomot Scooby-Doo.");
#endregion

#region 7.feladat
Console.WriteLine((DidScoobyDooCollectedSpecifiedAmountOfSnacks() ? "Talált" : "Nem talált") +
    " Scooby-Doo pontosan a megadott mennyiségű snacket.");
#endregion

#region 8.feladat
Console.WriteLine(FindInvestigationByLocation(out int index)
    ? $"{data[index].SnacksCollected} snacket talált Scooby-Doo a megadott helyszínen."
    : "A megadott helyszín nem található.");
#endregion

#region 9.feladat
Console.WriteLine($"Páros gyűjtött snackek: {string.Join(", ", EvenSnacksFound())}");
#endregion

#region 10.feladat
WriteAtLeast50SnacksCollectedToFile();
#endregion

#region 11.feladat
(int[] dividable, int[] unDividable) = DividableAndUnDividableBy3();
Console.WriteLine($"\n3-mal osztható: {string.Join(", ", dividable)}");
Console.WriteLine($"3-mal nem osztható: {string.Join(", ", unDividable)}");
#endregion

static Investigation[] ReadData()
{
    return File.ReadAllLines("nyomozas.txt")
        .Select(line =>
        {
            string[] lineArr = line.Split();
            return new Investigation(string.Join(' ', lineArr[..^1]), int.Parse(lineArr[^1]));
        }).ToArray();
}

double AvgSnackCollected()
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.SnacksCollected;
    }

    return sum / data.Length;
}

int CountLakeHeviz()
{
    int count = 0;

    foreach (var item in data)
    {
        if (item.Location == "Hévízi-tó") count++;
    }

    return count;
}

int MaxSnackCollected()
{
    int max = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].SnacksCollected > data[max].SnacksCollected) max = i;
    }

    return max;
}

bool DidScoobyDooCollectedSpecifiedAmountOfSnacks()
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

bool FindInvestigationByLocation(out int index)
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

int[] EvenSnacksFound()
{
    //return data
    //    .Where(item => item.SnacksCollected % 2 == 0)
    //    .Select(item => item.SnacksCollected)
    //    .ToArray();

    int[] evenSnacks = new int[data.Length];
    int len = 0;

    foreach (var item in data.Where(item => item.SnacksCollected % 2 == 0))
    {
        evenSnacks[len++] = item.SnacksCollected;
    }

    Array.Resize(ref evenSnacks, len);

    return evenSnacks;
}

void WriteAtLeast50SnacksCollectedToFile()
{
    var output = new StreamWriter("min-50-snack.txt");
    output.WriteLine(string.Join('\n',
        data.Where(item => item.SnacksCollected >= 50).Select(item => item.SnacksCollected)));
    output.Close();
}

(int[], int[]) DividableAndUnDividableBy3()
{
    int[] dividable = new int[data.Length];
    int[] unDividable = new int[data.Length];
    int i = 0;
    int j = 0;

    foreach (int item in data.Select(item => item.SnacksCollected))
    {
        if (item % 3 == 0) dividable[i++] = item;
        else unDividable[j++] = item;
    }

    Array.Resize(ref dividable, i);
    Array.Resize(ref unDividable, j);

    return (dividable, unDividable);
}

namespace Local
{
    public record Investigation(string Location, int SnacksCollected);
}