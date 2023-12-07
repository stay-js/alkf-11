using Local;

#region a.
var data = ReadData();
#endregion

#region b.
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine($"{i + 1}. versenyző - pozitív szavazat: {data[i].Positive}" +
        $" negatív szavazat: {data[i].Negative}");
}
#endregion

#region c.
Console.WriteLine($"\nÖsszesen {SumOfPositive(data)} pozitív szavazatot kaptak a versenyzők.");
#endregion

#region d.
Console.WriteLine($"Átlagosan {AvgOfNegative(data):N2} negtív szavazatot kaptak a versenyzők.");
#endregion

#region e.
var moreNegativeThanPositive = MoreNegativeThanPositive(data);

Console.WriteLine("\nAz alábbi versenyzők esetében volt több a negatív," +
    " mint a pozitív szavazatok aránya:");
foreach (var item in moreNegativeThanPositive)
{
    Console.WriteLine($"\t- pozitív: {item.Positive} negatív: {item.Negative}");
}
#endregion

#region f.
WriteRatiosToFile(data);
#endregion

#region g.
Console.WriteLine((DoesAtLeastSpecifiedDifferenceExist(data) ? "Volt" : "Nem volt") +
    " olyan versenyző akinek a szavazatai közti különbség legalább a megadott érték.");
#endregion

#region h.
int minIndex = MinIndex(data);
int maxIndex = MaxIndex(data);

Console.WriteLine($"\n{minIndex + 1}. versenyző kapta a legkevesebb szavazatot." +
    $" pozitív: {data[minIndex].Positive} negatív: {data[minIndex].Negative}");

Console.WriteLine($"{maxIndex + 1}. versenyző kapta a legtöbb szavazatot." +
    $" pozitív: {data[maxIndex].Positive}  negatív:  {data[maxIndex].Negative}");
#endregion

static Competitor[] ReadData()
{
    var input = new StreamReader("savaz.txt");
    int length = int.Parse(input.ReadLine() ?? "");

    var data = new Competitor[length];

    for (int i = 0; i < length && !input.EndOfStream; i++)
    {
        string[] line = (input.ReadLine() ?? "").Split();
        data[i] = new Competitor(int.Parse(line[0]), int.Parse(line[1]));
    }

    input.Close();

    return data;
}

static int SumOfPositive(Competitor[] data)
{
    int sum = 0;

    foreach (var item in data)
    {
        sum += item.Positive;
    }

    return sum;
}

static double AvgOfNegative(Competitor[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Negative;
    }

    return sum / data.Length;
}

static Competitor[] MoreNegativeThanPositive(Competitor[] data)
{
    var moreNegativeThanPositive = new Competitor[data.Length];
    int i = 0;

    foreach (var item in data.Where(item => item.Negative > item.Positive))
    {
        moreNegativeThanPositive[i++] = item;
    }

    var actualLength = new Competitor[i];

    for (i = 0; i < actualLength.Length; i++)
    {
        actualLength[i] = moreNegativeThanPositive[i];
    }

    return actualLength;
}

static void WriteRatiosToFile(Competitor[] data)
{
    var output = new StreamWriter("aranyok.txt");

    foreach (var item in data)
    {
        double ratio = Convert.ToDouble(item.Positive) / (item.Positive + item.Negative);
        output.WriteLine($"{ratio:N2}");
    }

    output.Close();
}

static bool DoesAtLeastSpecifiedDifferenceExist(Competitor[] data)
{
    Console.Write("\nAdja meg a keresett értéket: ");
    int query = int.Parse(Console.ReadLine() ?? "");

    int i = 0;

    while (i < data.Length && Math.Abs(data[i].Positive - data[i].Negative) < query)
    {
        i++;
    }

    return i < data.Length;
}

static int MinIndex(Competitor[] data)
{
    int min = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Positive + data[i].Negative < data[min].Positive + data[min].Negative) min = i;
    }

    return min;
}

static int MaxIndex(Competitor[] data)
{
    int max = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Positive + data[i].Negative > data[max].Positive + data[max].Negative) max = i;
    }

    return max;
}

namespace Local
{
    public record Competitor(int Positive, int Negative);
}