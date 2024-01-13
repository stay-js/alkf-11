using Local;

const int TABLE_SIZE = 9;

#region 1. feladat
Console.WriteLine("1. feladat");
Console.Write("Adja meg a bemeneti fájl nevét! ");
string file = (Console.ReadLine() ?? "");

int row, column;

do Console.Write("Adja meg egy sor számát! ");
while (!int.TryParse(Console.ReadLine(), out row));

do Console.Write("Adja meg egy oszlop számát! ");
while (!int.TryParse(Console.ReadLine(), out column));
#endregion

#region 2. feladat
var (table, steps) = ReadData(file);
#endregion

#region 3. feladat
Console.WriteLine("\n3. feladat");

int number = table[row - 1, column - 1];
if (number == 0) Console.WriteLine("Az adott helyet még nem töltötték ki");
else Console.WriteLine($"Az adott helyen szereplő szám: {number}");

Console.WriteLine($"A hely a(z) {GetPartTable(row, column)} résztáblázathoz tartozik.");
#endregion

#region 4. feladat
Console.WriteLine("\n4. feladat");
Console.WriteLine($"Az üres helyek aránya: {CalculateEmptyRatio():P1}");
#endregion

#region 5. feladat
Console.WriteLine("\n5. feladat");
TrySteps();
#endregion

static (int[,], Step[]) ReadData(string file)
{
    string[] input = File.ReadAllLines(file);
    int[,] table = new int[TABLE_SIZE, TABLE_SIZE];
    var steps = new Step[4];

    for (int i = 0; i < TABLE_SIZE; i++)
    {
        int[] row = input[i].Split().Select(int.Parse).ToArray();

        for (int j = 0; j < TABLE_SIZE; j++)
        {
            table[i, j] = row[j];
        }
    }

    for (int i = 0; i < steps.Length; i++)
    {
        int[] row = input[TABLE_SIZE + i].Split().Select(int.Parse).ToArray();
        steps[i] = new Step(row[0], row[1] - 1, row[2] - 1);
    }

    return (table, steps);
}

static bool CheckRow(int[,] table, int row, int num)
{
    int i = 0;

    while (i < TABLE_SIZE && table[row, i] != num)
    {
        i++;
    }

    return i >= TABLE_SIZE;
}

static bool CheckColumn(int[,] table, int column, int num)
{
    int i = 0;

    while (i < TABLE_SIZE && table[i, column] != num)
    {
        i++;
    }

    return i >= TABLE_SIZE;
}

static int GetPartTable(int row, int column)
{
    int partTable;

    if (row <= 3)
    {
        if (column <= 3) partTable = 1;
        else if (column <= 6) partTable = 2;
        else partTable = 3;
    }
    else if (row <= 6)
    {
        if (column <= 3) partTable = 4;
        else if (column <= 6) partTable = 5;
        else partTable = 6;
    }
    else
    {
        if (column <= 3) partTable = 7;
        else if (column <= 6) partTable = 8;
        else partTable = 9;
    }

    return partTable;
}

static bool CheckPartTable(int[,] table, int row, int column, int num)
{
    var x = (-1, -1);
    var y = (-1, -1);

    switch (GetPartTable(row, column))
    {
        case 1:
            x = (0, 2);
            y = (0, 2);
            break;
        case 2:
            x = (3, 5);
            y = (0, 2);
            break;
        case 3:
            x = (5, 8);
            y = (0, 2);
            break;
        case 4:
            x = (0, 2);
            y = (3, 5);
            break;
        case 5:
            x = (3, 5);
            y = (3, 5);
            break;
        case 6:
            x = (5, 8);
            y = (3, 5);
            break;
        case 7:
            x = (0, 2);
            y = (5, 8);
            break;
        case 8:
            x = (3, 5);
            y = (5, 8);
            break;
        case 9:
            x = (5, 8);
            y = (5, 8);
            break;
    }

    for (int i = y.Item1; i < y.Item2; i++)
    {
        for (int j = x.Item1; j < x.Item2; j++)
        {
            if (table[i, j] == num) return true;
        }
    }

    return false;
}

double CalculateEmptyRatio()
{
    double emptySpaces = 0;

    for (int i = 0; i < TABLE_SIZE; i++)
    {
        for (int j = 0; j < TABLE_SIZE; j++)
        {
            if (table[i, j] == 0) emptySpaces++;
        }
    }

    return emptySpaces / (TABLE_SIZE * TABLE_SIZE);
}

void TrySteps()
{
    foreach (var (number, row, column) in steps)
    {
        Console.WriteLine($"A kiválasztott sor: {row + 1} oszlop: {column + 1} a szám: {number}");
        if (table[row, column] != 0)
            Console.WriteLine("A helyet már kitöltötték.\n");
        else if (!CheckRow(table, row, number))
            Console.WriteLine("Az adott sorban már szerepel a szám.\n");
        else if (!CheckColumn(table, column, number))
            Console.WriteLine("Az adott oszlopban már szerepel a szám.\n");
        else if (!CheckPartTable(table, row, column, number))
            Console.WriteLine("Az adott résztáblázatban már szerepel a szám.\n");
        else
            Console.WriteLine("A lépés megtehető.\n");
    }
}

namespace Local
{
    public record Step(int Number, int Row, int Column);
}