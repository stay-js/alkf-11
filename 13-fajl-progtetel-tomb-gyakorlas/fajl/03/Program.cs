using System.Text;


#region a
var data = ReadData();

foreach (var item in data)
{
    Console.WriteLine($"{item.Item1}: " +
        $"{item.Item2} + {item.Item3} = {item.Item4} pont.");
}
#endregion

#region b
Console.WriteLine($"\n{data[MaxScoreIndex(data)].Item1} érte el a legmagasabb pontszámot.");
#endregion

#region c
Console.WriteLine($"Az átlagos elért összponszám: {Math.Round(AvgScore(data), 2)} pont.");
#endregion

#region d
if (FindStudent(data, out int index))
{
    var student = data[index];
    Console.WriteLine($"A megadott felvételiző: " +
        $"{student.Item2} + {student.Item3} = {student.Item4} pontot ért el.");
}
else Console.WriteLine("A megadott felvételiző nem található.");
#endregion

#region e
WriteTotalScoresToFile(data);
#endregion

static (string, int, int, int)[] ReadData()
{
    return File.ReadLines("felveteli.csv")
        .Select((line) =>
        {
            var lineArr = line.Split(';');
            int brought = int.Parse(lineArr[1]);
            int achieved = int.Parse(lineArr[2]);

            return (lineArr[0].Trim(), brought, achieved, brought + achieved);
        }).ToArray();
}

static int MaxScoreIndex((string, int, int, int)[] data)
{
    int max = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Item4 > data[max].Item4) max = i;
    }

    return max;
}

static double AvgScore((string, int, int, int)[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Item4;
    }

    return sum / data.Length;
}

static bool FindStudent((string, int, int, int)[] data, out int index)
{
    Console.Write("\nAdja meg egy felvételiző nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Item1.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}

static void WriteTotalScoresToFile((string, int, int, int)[] data)
{
    var output = new StreamWriter("osszpontok.csv", false, Encoding.UTF8);

    output.WriteLine(data.Length);

    foreach (var item in data)
    {
        output.WriteLine($"{item.Item1};{item.Item4}");
    }

    output.Close();
}