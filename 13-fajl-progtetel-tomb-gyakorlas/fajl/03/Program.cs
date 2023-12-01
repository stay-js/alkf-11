using Local;

#region a
var data = ReadData();
PrintAllStudents(data);
#endregion

#region b
Console.WriteLine($"\n{data[MaxScoreIndex(data)].Name} érte el a legmagasabb pontszámot.");
#endregion

#region c
Console.WriteLine($"Az átlagos elért összponszám: {Math.Round(AvgScore(data), 2)} pont.");
#endregion

#region d
if (FindStudent(data, out int index))
{
    var student = data[index];
    Console.WriteLine($"A megadott felvételiző: " +
        $"{student.BroughtScore} + {student.AchievedScore} = {student.TotalScore} pontot ért el.");
}
else Console.WriteLine("A megadott felvételiző nem található.");
#endregion

#region e
WriteTotalScoresToFile(data);
#endregion

static Student[] ReadData()
{
    return File.ReadLines("felveteli.csv")
        .Select(line =>
        {
            string[] lineArr = line.Split(';');
            int brought = int.Parse(lineArr[1]);
            int achieved = int.Parse(lineArr[2]);

            return new Student(lineArr[0].Trim(), brought, achieved, brought + achieved);
        }).ToArray();
}

static void PrintAllStudents(Student[] students)
{
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Name}: " +
            $"{student.BroughtScore} + {student.AchievedScore} = {student.TotalScore} pont.");
    }
}

static int MaxScoreIndex(Student[] data)
{
    int max = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].TotalScore > data[max].TotalScore) max = i;
    }

    return max;
}

static double AvgScore(Student[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.TotalScore;
    }

    return sum / data.Length;
}

static bool FindStudent(Student[] data, out int index)
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

static void WriteTotalScoresToFile(Student[] data)
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