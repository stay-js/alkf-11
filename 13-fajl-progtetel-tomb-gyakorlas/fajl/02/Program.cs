#region a
var data = ReadData();
foreach (var item in data)
{
    Console.WriteLine($"{item.Item1}: {item.Item2} pont");
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
    ? $"{data[index].Item2} pontot ért el."
    : "nem található."));
#endregion

static (string, int)[] ReadData()
{
    var data = new (string, int)[50];
    var input = new StreamReader("pontszamok.txt");

    int i = 0;
    while (i < data.Length && !input.EndOfStream)
    {
        string name = input.ReadLine() ?? "";
        int score = int.Parse(input.ReadLine() ?? "");
        data[i++] = (name, score);
    }

    input.Close();

    var actualLength = new (string, int)[i];

    for (i = 0; i < actualLength.Length; i++)
    {
        actualLength[i] = data[i];

    }

    return actualLength;
}

static int MinScore((string, int)[] data)
{
    int min = data[0].Item2;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Item2 < min) min = data[i].Item2;
    }

    return min;
}

static int MaxScore((string, int)[] data)
{
    int max = data[0].Item2;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Item2 > max) max = data[i].Item2;
    }

    return max;
}

static double AvgScore((string, int)[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Item2;
    }

    return sum / data.Length;
}

static bool FindCompetitor((string, int)[] data, out int index)
{
    Console.Write("\nAdja meg egy versenyző nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Item1.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}