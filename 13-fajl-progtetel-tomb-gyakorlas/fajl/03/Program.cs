using Local;

#region a
var data = ReadData();
PrintAllStudents();
#endregion

#region b
Console.WriteLine($"\n{data[MaxScoreIndex()].Name} érte el a legmagasabb pontszámot.");
#endregion

#region c
Console.WriteLine($"Az átlagos elért összponszám: {Math.Round(AvgScore(), 2)} pont.");
#endregion

#region d
if (FindStudent(out int index))
{
    var student = data[index];
    Console.WriteLine($"A megadott felvételiző: " +
        $"{student.BroughtScore} + {student.AchievedScore} = {student.TotalScore} pontot ért el.");
}
else Console.WriteLine("A megadott felvételiző nem található.");
#endregion

#region e
WriteTotalScoresToFile();
#endregion

static Student[] ReadData()
{
    return File.ReadAllLines("felveteli.csv")
        .Select(line =>
        {
            string[] lineArr = line.Split(';');
            int brought = int.Parse(lineArr[1]);
            int achieved = int.Parse(lineArr[2]);

            return new Student(lineArr[0].Trim(), brought, achieved, brought + achieved);
        }).ToArray();
}

void PrintAllStudents()
{
    foreach (var student in data)
    {
        Console.WriteLine($"{student.Name}: " +
            $"{student.BroughtScore} + {student.AchievedScore} = {student.TotalScore} pont.");
    }
}

int MaxScoreIndex()
{
    int max = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].TotalScore > data[max].TotalScore) max = i;
    }

    return max;
}

double AvgScore()
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.TotalScore;
    }

    return sum / data.Length;
}

bool FindStudent(out int index)
{
    Console.Write("\nAdja meg egy felvételiző nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}

void WriteTotalScoresToFile()
{
    var output = new StreamWriter("osszpontok.csv", false, System.Text.Encoding.UTF8);

    output.WriteLine(data.Length);
    output.WriteLine(string.Join('\n', data.Select(item => $"{item.Name};{item.TotalScore}")));
    output.Close();
}

namespace Local
{
    public record Student(string Name, int BroughtScore, int AchievedScore, int TotalScore);
}