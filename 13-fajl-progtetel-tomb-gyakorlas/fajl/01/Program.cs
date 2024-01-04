using Local;

#region a
var data = ReadData();
Console.WriteLine($"{data.Length} diák adata került rögzítésre.");
#endregion

#region b
Console.WriteLine($"A megadott évben {CountStudentsByYear()} diák kezdte az iskolát.");
#endregion

#region c
Console.WriteLine(FindStudent(out int index)
    ? $"A megadott diák {data[index].Year}-ban/ben kezdte az iskolát, " +
      $"és a(z) {data[index].Class} jelű osztályba járt."
    : "A megadott diák nem található.");
#endregion

#region d
var students = FindStudents();
Console.WriteLine(students.Length > 0
    ? $"A megadott névrészletnek megfelelő tanulók:\n" +
        string.Join('\n', students.Select(student =>
        $"{student.Name}, kezdés éve: {student.Year}, osztály: {student.Class}"))
    : "Nincs a megadott névrészletnek megfelelő tanuló.");
#endregion

#region e
var longestName = data[LongestName()];
Console.WriteLine($"\nA leghosszabb nevű tanuló: {longestName.Name}, " +
    $"{longestName.Year}-ban/ben kezdte a tanulmányait a(z) {longestName.Class} jelű osztályban.");
#endregion

#region f
WriteNamesToFile();
#endregion

static Student[] ReadData()
{
    return File.ReadLines("adatok.txt")
        .Select(line =>
        {
            string[] lineArr = line.Split();
            return new Student(int.Parse(lineArr[0]), lineArr[1], string.Join(' ', lineArr[2..]));
        }).ToArray();
}

int CountStudentsByYear()
{
    Console.Write("\nAdjon meg egy évszámot: ");
    int year = int.Parse(Console.ReadLine() ?? "");

    int count = 0;

    foreach (var item in data)
    {
        if (year == item.Year) count++;
    }

    return count;
}

bool FindStudent(out int index)
{
    Console.Write("\nAdja meg egy diák nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}

Student[] FindStudents()
{
    Console.Write("\nAdjon meg egy névrészletet: ");
    string query = Console.ReadLine() ?? "";

    //return data
    //    .Where(item => item.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase))
    //    .ToArray();

    var foundStudents = new Student[data.Length];
    int len = 0;

    foreach (var item in
        data.Where(item => item.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase)))
    {
        foundStudents[len++] = item;
    }

    Array.Resize(ref foundStudents, len);

    return foundStudents;
}

int LongestName()
{
    int longestName = 0;

    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Name.Length > data[longestName].Name.Length) longestName = i;
    }

    return longestName;
}

void WriteNamesToFile()
{
    var output = new StreamWriter("nevsor.txt");
    output.WriteLine(string.Join('\n', data.Select(item => item.Name)));
    output.Close();
}

namespace Local
{
    public record Student(int Year, string Class, string Name);
}