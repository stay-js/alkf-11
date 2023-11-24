using Local;

#region a
var data = ReadData();
foreach (var item in data)
{
    Console.WriteLine($"{item.Name}: {item.Score} pont");
}
#endregion

#region b
Console.WriteLine($"\n{data.Length} versenyző adatait tartalmazza a fájl.");
#endregion

#region c
Console.WriteLine($"A legalacsonyabb elért pontszám {MinScore(data)} pont, " +
    $"a legmagasabb pedig {MaxScore(data)} pont");
#endregion

#region d
Console.WriteLine($"Az átlagos pontszám: {Math.Round(AvgScore(data), 2)}. pont");
#endregion

#region e
Console.WriteLine("A megadott versenyző " + (FindCompetitor(data, out int index)
    ? $"{data[index].Score} pontot ért el."
    : "nem található."));
#endregion

static Competitor[] ReadData()
{
    var data = new Competitor[50];
    var input = new StreamReader("pontszamok.txt");

    int i = 0;
    while (i < data.Length && !input.EndOfStream)
    {
        data[i++] = new Competitor(input.ReadLine() ?? "", int.Parse(input.ReadLine() ?? ""));
    }

    input.Close();

    var actualLength = new Competitor[i];

    for (i = 0; i < actualLength.Length; i++)
    {
        actualLength[i] = data[i];

    }

    return actualLength;
}

static int MinScore(Competitor[] data)
{
    int min = data[0].Score;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Score < min) min = data[i].Score;
    }

    return min;
}

static int MaxScore(Competitor[] data)
{
    int max = data[0].Score;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Score > max) max = data[i].Score;
    }

    return max;
}

static double AvgScore(Competitor[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Score;
    }

    return sum / data.Length;
}

static bool FindCompetitor(Competitor[] data, out int index)
{
    Console.Write("\nAdja meg egy versenyző nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}

namespace Local
{
    public record Competitor(string Name, int Score);
}