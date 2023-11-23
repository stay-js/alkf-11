#region a
var data = ReadData();
Console.WriteLine($"{data.Length} diák adata került rögzítésre.");
#endregion

#region b
Console.WriteLine($"A megadott évben {CountStudentsByYear(data)} diák kezdte az iskolát.");
#endregion

#region c
Console.WriteLine(FindStudent(data, out int index)
    ? $"A megadott diák {data[index].Item1}-ban/ben kezdte az iskolát, " +
      $"és a(z) {data[index].Item2} jelű osztályba járt."
    : "A megadott diák nem található.");
#endregion

#region d
var foundStudents = FindStudents(data);
Console.WriteLine(foundStudents.Length > 0
    ? $"A megadott névrészletnek megfelelő tanulók:\n" + string.Join('\n', foundStudents)
    : "Nincs a megadott névrészletnek megfelelő tanuló.");
#endregion

#region e
var longestName = data[LongestName(data)];
Console.WriteLine($"\nA leghosszabb nevű tanuló: {longestName.Item3}, " +
    $"{longestName.Item1}-ban/ben kezdte a tanulmányait a(z) {longestName.Item2} jelű osztályban.");
#endregion

#region f
WriteNamesToFile(data);
#endregion

static (int, string, string)[] ReadData()
{
    return File.ReadLines("adatok.txt")
        .Select((line) =>
        {
            var lineArr = line.Split();
            return (int.Parse(lineArr[0]), lineArr[1], string.Join(' ', lineArr[2..]));
        }).ToArray();
}

static int CountStudentsByYear((int, string, string)[] students)
{
    Console.Write("\nAdjon meg egy évszámot: ");
    int year = int.Parse(Console.ReadLine() ?? "");

    int count = 0;

    foreach (var student in students)
    {
        if (year == student.Item1) count++;
    }

    return count;
}

static bool FindStudent((int, string, string)[] students, out int index)
{
    Console.Write("\nAdja meg egy diák nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < students.Length
        && !students[index].Item3.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < students.Length;
}

static (int, string, string)[] FindStudents((int, string, string)[] students)
{
    Console.Write("\nAdjon meg egy névrészletet: ");
    string query = Console.ReadLine() ?? "";

    var foundStudents = new (int, string, string)[students.Length];
    int i = 0;

    foreach (var student in
        students.Where((x) => x.Item3.Contains(query, StringComparison.CurrentCultureIgnoreCase)))
    {
        foundStudents[i++] = student;
    }

    var actualLength = new (int, string, string)[i];

    for (i = 0; i < actualLength.Length; i++)
    {
        actualLength[i] = foundStudents[i];
    }

    return actualLength;
}

static int LongestName((int, string, string)[] students)
{
    int longestName = 0;

    for (int i = 0; i < students.Length; i++)
    {
        if (students[i].Item3.Length > students[longestName].Item3.Length) longestName = i;
    }

    return longestName;
}

static void WriteNamesToFile((int, string, string)[] students)
{
    var output = new StreamWriter("nevsor.txt");
    output.WriteLine(string.Join('\n', students));
    output.Close();
}
