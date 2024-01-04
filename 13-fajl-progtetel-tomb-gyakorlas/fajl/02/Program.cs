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
Console.WriteLine($"A legalacsonyabb elért pontszám {MinScore()} pont, " +
    $"a legmagasabb pedig {MaxScore()} pont");
#endregion

#region d
Console.WriteLine($"Az átlagos pontszám: {Math.Round(AvgScore(), 2)}. pont");
#endregion

#region e
Console.WriteLine("A megadott versenyző " + (FindCompetitor(out int index)
    ? $"{data[index].Score} pontot ért el."
    : "nem található."));
#endregion

static Competitor[] ReadData()
{
    var data = new Competitor[50];
    var input = new StreamReader("pontszamok.txt");

    int len = 0;
    while (len < data.Length && !input.EndOfStream)
    {
        data[len++] = new Competitor(input.ReadLine() ?? "", int.Parse(input.ReadLine() ?? ""));
    }

    input.Close();

    Array.Resize(ref data, len);

    return data;
}

int MinScore()
{
    int min = data[0].Score;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Score < min) min = data[i].Score;
    }

    return min;
}

int MaxScore()
{
    int max = data[0].Score;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Score > max) max = data[i].Score;
    }

    return max;
}

double AvgScore()
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Score;
    }

    return sum / data.Length;
}

bool FindCompetitor(out int index)
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