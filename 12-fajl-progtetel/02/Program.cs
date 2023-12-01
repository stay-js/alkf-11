string[] names = File.ReadAllLines("nevek.txt");

#region a.
Console.WriteLine(CountPeopleWithMultipleLastNames(names) +
    "beolvasott embernek van legalább 2 keresztneve.");
#endregion

#region b.
Console.WriteLine($"\nBeolvasott nevek ABC sorrendben:" +
    string.Join(", ", StringBubbleSort(names)));
#endregion

#region c.
SelectFelelok(names, 3);
#endregion

#region d.
WriteUpperNamesToFile(names);
#endregion

#region e.
WriteOrderedNamesToFile(names);
#endregion

#region f.
Console.WriteLine("\nKeresztnevek ABC sorrendben:\n" + string.Join(", ", SortedLastNames(names)));
#endregion

#region g.
if (FindNameByMonogram(names, out string foundName)) Console.WriteLine(foundName);
else Console.WriteLine("Nincs ilyen monogrammal rendelkező ember a listán.");
#endregion

static string[] StringBubbleSort(string[] array)
{
    string[] sortedArray = array[..];

    for (int i = sortedArray.Length; i >= 1; i--)
    {
        for (int j = 0; j < i - 1; j++)
        {
            if (string.Compare(sortedArray[j], sortedArray[j + 1]) > 0)
            {
                (sortedArray[j], sortedArray[j + 1]) = (sortedArray[j + 1], sortedArray[j]);
            }
        }
    }

    return sortedArray;
}

static bool Contains(string[] array, int length, string item)
{
    int i = 0;

    while (i < length && array[i] != item)
    {
        i++;
    }

    return i < length;
}

static int CountPeopleWithMultipleLastNames(string[] names)
{
    int count = 0;

    foreach (string name in names)
    {
        if (name.Split().Length >= 3) count++;
    }

    return count;
}

static void SelectFelelok(string[] names, int amount)
{
    string[] randomNames = new string[amount];
    int i = 0;

    while (i < randomNames.Length)
    {
        string selectedName = names[Random.Shared.Next(names.Length)];
        if (!Contains(randomNames, i, selectedName)) randomNames[i++] = selectedName;
    }

    var output = new StreamWriter("felelok.txt");
    output.WriteLine(string.Join("\n", randomNames));
    output.Close();
}

static void WriteUpperNamesToFile(string[] names)
{
    var output = new StreamWriter("nagybetus.txt");

    foreach (string name in names)
    {
        output.WriteLine(name.ToUpper());
    }

    output.Close();
}

static void WriteOrderedNamesToFile(string[] names)
{
    var output = new StreamWriter("rendezett.txt");
    output.WriteLine(string.Join("\n", StringBubbleSort(names)));
    output.Close();
}

static string[] SortedLastNames(string[] names)
{
    string[] lastNames = new string[names.Length];
    int i = 0;

    foreach (string name in names)
    {
        string firstName = string.Join(' ', name.Split()[1..]);
        if (!Contains(lastNames, i, firstName)) lastNames[i++] = firstName;
    }

    return StringBubbleSort(lastNames[..i]);
}

static bool FindNameByMonogram(string[] names, out string name)
{
    Console.Write("\nAdjon meg egy monogrammot: ");
    string monogramm = (Console.ReadLine() ?? "").ToUpper();

    int i = 0;

    while (i < names.Length
        && string.Concat(names[i].Split().Select(name => name[0])) != monogramm)
    {
        i++;
    }

    name = names[i];
    return i < names.Length;
}