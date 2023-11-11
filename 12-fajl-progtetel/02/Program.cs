string[] names = File.ReadAllLines("nevek.txt");

#region a.
int count = 0;

foreach (string name in names)
{
    if (name.Split().Length == 3) count++;
}

Console.WriteLine($"{count} beolvasott embernek van 2 keresztneve.");
#endregion

#region b - e.
string[] sortedNames = StringBubbleSort(names);

var output = new StreamWriter("rendezett.txt");

Console.WriteLine("\nBeolvasott nevek ABC sorrendben:");

foreach (string name in sortedNames)
{
    Console.WriteLine(name);
    output.WriteLine(name);
}

output.Close();
#endregion

#region c.
const int AMOUNT_TO_PICK = 3;
string[] randomNames = new string[AMOUNT_TO_PICK];
int i = 0;

while(i < AMOUNT_TO_PICK)
{
    string selectedName = names[Random.Shared.Next(names.Length)];
    if (!Contains(randomNames, i, selectedName)) randomNames[i++] = selectedName;
}

output = new StreamWriter("felelok.txt");
output.WriteLine(string.Join("\n", randomNames));
output.Close();
#endregion

#region d.
output = new StreamWriter("nagybetus.txt");

foreach (string name in names)
{
    output.WriteLine(name.ToUpper());
}

output.Close();
#endregion

#region f.
string[] firstNames = new string[names.Length];
i = 0;

foreach (string name in names)
{
    string firstName = string.Join(' ', name.Split()[1..]);
    if (!Contains(firstNames, i, firstName)) firstNames[i++] = firstName;
}

string[] firstNamesActualLength = new string[i];
for (int j = 0; j < i; j++)
{
    firstNamesActualLength[j] = firstNames[j];
}

Console.WriteLine("\nKeresztnevek ABC sorrendben:\n" +
    string.Join(", ", StringBubbleSort(firstNamesActualLength)));
#endregion

#region g.
Console.Write("\nAdjon meg egy monogrammot: ");
string monogramm = (Console.ReadLine() ?? "").ToUpper();

int k = 0;

while (k < names.Length && string.Concat(names[k].Split().Select((name) => name[0])) != monogramm)
{
    k++;
}

if (k < names.Length) Console.WriteLine(names[k]);
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