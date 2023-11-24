using Local;

#region a
var data = ReadData();
Console.WriteLine($"{data.Length} diák adata került rögzítésre.");
#endregion

#region b
Console.WriteLine($"A megadott évben {CountStudentsByYear(data)} diák kezdte az iskolát.");
#endregion

#region c
Console.WriteLine(FindStudent(data, out int index)
    ? $"A megadott diák {data[index].Year}-ban/ben kezdte az iskolát, " +
      $"és a(z) {data[index].Class} jelű osztályba járt."
    : "A megadott diák nem található.");
#endregion

#region d
var students = FindStudents(data);
Console.WriteLine(students.Length > 0
    ? $"A megadott névrészletnek megfelelő tanulók:\n" +
        string.Join('\n', students.Select((student) =>
        $"{student.Name}, kezdés éve: {student.Year}, osztály: {student.Class}"))
    : "Nincs a megadott névrészletnek megfelelő tanuló.");
#endregion

#region e
var longestName = data[LongestName(data)];
Console.WriteLine($"\nA leghosszabb nevű tanuló: {longestName.Name}, " +
    $"{longestName.Year}-ban/ben kezdte a tanulmányait a(z) {longestName.Class} jelű osztályban.");
#endregion

#region f
WriteNamesToFile(data);
#endregion

static Student[] ReadData()
{
    return File.ReadLines("adatok.txt")
        .Select((line) =>
        {
            var lineArr = line.Split();
            return new Student(int.Parse(lineArr[0]), lineArr[1], string.Join(' ', lineArr[2..]));
        }).ToArray();
}

static int CountStudentsByYear(Student[] data)
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

static bool FindStudent(Student[] data, out int index)
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

static Student[] FindStudents(Student[] data)
{
    Console.Write("\nAdjon meg egy névrészletet: ");
    string query = Console.ReadLine() ?? "";

    var foundStudents = new Student[data.Length];
    int i = 0;

    foreach (var item in
        data.Where((x) => x.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase)))
    {
        foundStudents[i++] = item;
    }

    var actualLength = new Student[i];

    for (i = 0; i < actualLength.Length; i++)
    {
        actualLength[i] = foundStudents[i];
    }

    return actualLength;
}

static int LongestName(Student[] data)
{
    int longestName = 0;

    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Name.Length > data[longestName].Name.Length) longestName = i;
    }

    return longestName;
}

static void WriteNamesToFile(Student[] data)
{
    var output = new StreamWriter("nevsor.txt");

    foreach (var student in data)
    {
        output.WriteLine(student.Name);
    }

    output.Close();
}

namespace Local
{
    public record Student(int Year, string Class, string Name);
}