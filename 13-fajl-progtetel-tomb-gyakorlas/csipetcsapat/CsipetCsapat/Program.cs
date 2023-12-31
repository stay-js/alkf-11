﻿#region 2.feladat
int[] data = ReadData();
#endregion

#region 3. feladat
Console.WriteLine((IsZeroInData() ? "Volt" : "Nem volt") +
    " olyan nap amikor nem gyűjtöttek egy diót és mogyorót sem.");
#endregion

#region 4. feladat
Console.WriteLine($"{AtLeast45()} nap gyűjtöttek legalább 45 darab diót és mogyorót.");
#endregion

#region 5. feladat
Console.WriteLine(FindSpecifiedValue(out int index)
    ? $"{index + 1}. napon találtak a megadott értéknek megfelelő diót és mogyorót."
    : "A keresett érték nem található");
#endregion

#region 6.feladat
Console.WriteLine($"\n{CountOddValues()} " +
    "olyan nap volt, amikor nem tudták egyenlő részre szétosztani maguk között az elemózsiát.");
#endregion

#region 7.feladat
Console.WriteLine($"A(z) {FindDividableBy5() + 1}. " +
    "az első olyan nap, amikor 5 fele szétosztható az élelem a csapattagok számára.");
#endregion

#region 8.feladat
WriteTurboToFile();
#endregion

static int[] ReadData()
{
    var input = new StreamReader("gyujtemeny.txt");
    int length = int.Parse(input.ReadLine() ?? "");

    int[] data = new int[length];

    for (int i = 0; i < length && !input.EndOfStream; i++)
    {
        data[i] = int.Parse(input.ReadLine() ?? "");
    }

    input.Close();

    return data;
}

bool IsZeroInData()
{
    int i = 0;

    while (i < data.Length && data[i] != 0)
    {
        i++;
    }

    return i < data.Length;
}

int AtLeast45()
{
    int count = 0;

    foreach (int i in data)
    {
        if (i >= 45) count++;
    }

    return count;
}

bool FindSpecifiedValue(out int index)
{
    Console.Write("\nAdja meg a keresett értéket: ");
    int amount = int.Parse(Console.ReadLine() ?? "");

    index = 0;

    while (index < data.Length && data[index] != amount)
    {
        index++;
    }

    return index < data.Length;
}

int CountOddValues()
{
    int count = 0;

    foreach (int i in data)
    {
        if (i % 2 != 0) count++;
    }

    return count;
}

int FindDividableBy5()
{
    int i = 0;

    while (data[i] % 5 != 0)
    {
        i++;
    }

    return i;
}

void WriteTurboToFile()
{
    int[] turbo = data.Select(x => x * 3).ToArray();

    var output = new StreamWriter("turbo.txt");

    for (int i = 0; i < turbo.Length; i++)
    {
        output.WriteLine($"{i + 1}. nap: {turbo[i]} darab");
    }

    output.Close();
}