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
Console.WriteLine($"\nÖsszesen {SumOfPositive()} pozitív szavazatot kaptak a versenyzők.");
#endregion

#region d.
Console.WriteLine($"Átlagosan {AvgOfNegative():N2} negtív szavazatot kaptak a versenyzők.");
#endregion

#region e.
var moreNegativeThanPositive = MoreNegativeThanPositive();

Console.WriteLine("\nAz alábbi versenyzők esetében volt több a negatív," +
    " mint a pozitív szavazatok aránya:");
foreach (var item in moreNegativeThanPositive)
{
    Console.WriteLine($"\t- pozitív: {item.Positive} negatív: {item.Negative}");
}
#endregion

#region f.
WriteRatiosToFile();
#endregion

#region g.
Console.WriteLine((DoesAtLeastSpecifiedDifferenceExist() ? "Volt" : "Nem volt") +
    " olyan versenyző akinek a szavazatai közti különbség legalább a megadott érték.");
#endregion

#region h.
int minIndex = MinIndex();
int maxIndex = MaxIndex();

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

int SumOfPositive()
{
    int sum = 0;

    foreach (var item in data)
    {
        sum += item.Positive;
    }

    return sum;
}

double AvgOfNegative()
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Negative;
    }

    return sum / data.Length;
}

Competitor[] MoreNegativeThanPositive()
{
    var moreNegativeThanPositive = new Competitor[data.Length];
    int len = 0;

    foreach (var item in data.Where(item => item.Negative > item.Positive))
    {
        moreNegativeThanPositive[len++] = item;
    }

    Array.Resize(ref moreNegativeThanPositive, len);

    return moreNegativeThanPositive;
}

void WriteRatiosToFile()
{
    var output = new StreamWriter("aranyok.txt");

    foreach (var item in data)
    {
        double ratio = Convert.ToDouble(item.Positive) / (item.Positive + item.Negative);
        output.WriteLine($"{ratio:N2}");
    }

    output.Close();
}

bool DoesAtLeastSpecifiedDifferenceExist()
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

int MinIndex()
{
    int min = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Positive + data[i].Negative < data[min].Positive + data[min].Negative) min = i;
    }

    return min;
}

int MaxIndex()
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