#region a, b.
Console.Write("Adja meg a beolvasandó fájl nevét: ");
var input = new StreamReader(Console.ReadLine() ?? "");
int length = Convert.ToInt32(input.ReadLine());
int[] numbers = new int[length];

for (int i = 0; i < length; i++)
{
    numbers[i] = Convert.ToInt32(input.ReadLine());
    Console.WriteLine($"{i + 1}. szám: {numbers[i]}");
}

input.Close();
#endregion

#region c.
Console.WriteLine($"\n{string.Join("\t", numbers)}");
#endregion

#region d.
var output = new StreamWriter("parosaval.txt");

for (int i = 0; i < length - 1; i++)
{
    int a = numbers[i];
    int b = numbers[i + 1];
    output.WriteLine($"{a};{b};{((a + b) / 2.0):N2}");
}

output.Close();
#endregion

#region e.
double sum = 0;

for (int i = 0; i < length; i++)
{
    sum += numbers[i];
}

Console.WriteLine($"\nA számok összege: {sum}");
#endregion

#region f.
Console.WriteLine($"A számok átlaga: {sum / length}");
#endregion

#region g.
int max = numbers[0];

for (int i = 1; i < length; i++)
{
    if (numbers[i] > max) max = numbers[i];
}

Console.WriteLine($"A számok maximuma: {max}");
#endregion

#region h.
int min = numbers[0];

for (int i = 1; i < length; i++)
{
    if (numbers[i] < min) min = numbers[i];
}

Console.WriteLine($"A számok minimuma: {min}");
#endregion

#region i.
int j = 0;

while (j < length && numbers[j] != 0)
{
    j++;
}

Console.WriteLine($"A számok között {(j < length ? "van" : "nincs")} nulla.");
#endregion

#region j.
j = 0;

while (j < length && numbers[j] >= 0)
{
    j++;
}

if (j < length) Console.WriteLine($"Az első negaív szám a {j + 1}. helyen áll.");
else Console.WriteLine("Nincs negatív szám a számok között.");
#endregion

#region k.
double countOfPositive = 0;

foreach (int number in numbers)
{
    if (number > 0) countOfPositive++;
}

Console.WriteLine($"A számok {(countOfPositive / length):P2} pozitív.");
#endregion