#region 1. feladat
int[,] data = ReadData();
#endregion

#region 2. feladat
Console.WriteLine("2. feladat");
Console.WriteLine($"A mért mélység az adott helyen {GetReading()} dm");
#endregion

#region 3. feladat
Console.WriteLine("3. feladat");
var (surface, avgDepth) = CalculateSurfaceAndAverageDepth();
Console.WriteLine($"A tó felszíne: {surface} m2, átlagos mélysége: {avgDepth:N2} m");
#endregion

#region 4.feladat
Console.WriteLine("4. feladat");
int maxDepth = MaxDepth();
Console.WriteLine($"A tó legnagyobb mélysége: {maxDepth} dm");

Console.WriteLine("A legmélyebb jelyek sor-oszlop koordinátái:");
var points = FindPointsWithSpecificDepth(maxDepth);
foreach (var (row, column) in points)
{
    Console.Write($"({row + 1}; {column + 1})  ");
}
Console.WriteLine();
#endregion

#region 5.feladat
Console.WriteLine("5. feladat");
Console.WriteLine($"A tó partvonala {CalculateShoreLength()} m hosszú");
#endregion

#region
Console.WriteLine("6. feladat");
CreateDiagram();
#endregion

static int[,] ReadData()
{
    string[] input = File.ReadAllLines("melyseg.txt");
    int rows = int.Parse(input[0]);
    int columns = int.Parse(input[1]);

    int[,] data = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        string[] line = input[i + 2].Split();

        for (int j = 0; j < columns; j++)
        {
            data[i, j] = int.Parse(line[j]);
        }
    }

    return data;
}

int GetReading()
{
    int row, column;

    do Console.Write("A mérés sorának azonosítója=");
    while (!int.TryParse(Console.ReadLine(), out row));

    do Console.Write("A mérés oszlopának azonosítója=");
    while (!int.TryParse(Console.ReadLine(), out column));

    return data[row - 1, column - 1];
}

(int, double) CalculateSurfaceAndAverageDepth()
{
    int surface = 0;
    double sumOfDepth = 0;

    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            if (data[i, j] != 0)
            {
                surface++;
                sumOfDepth += data[i, j];
            }
        }
    }

    return (surface, sumOfDepth / surface / 10);
}

int MaxDepth()
{
    int max = 0;

    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            if (data[i, j] > max) max = data[i, j];
        }
    }

    return max;
}

(int, int)[] FindPointsWithSpecificDepth(int depth)
{
    var points = new (int, int)[data.Length];
    int len = 0;

    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            if (data[i, j] == depth) points[len++] = (i, j);
        }
    }

    Array.Resize(ref points, len);

    return points;
}

int CalculateShoreLength()
{
    int shoreLength = 0;

    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            if (data[i, j] == 0) continue;
            if (data[i - 1, j] != 0
                && data[i + 1, j] != 0
                && data[i, j - 1] != 0
                && data[i, j + 1] != 0)
            {
                continue;
            }

            if (data[i - 1, j] == 0) shoreLength++;
            if (data[i + 1, j] == 0) shoreLength++;
            if (data[i, j - 1] == 0) shoreLength++;
            if (data[i, j + 1] == 0) shoreLength++;
        }
    }

    return shoreLength;
}

void CreateDiagram()
{
    int column;

    do Console.Write("A vizsgált szelvény oszlopának azonosítója=");
    while (!int.TryParse(Console.ReadLine(), out column));

    var output = new StreamWriter("diagram.txt");

    for (int i = 0; i < data.GetLength(0); i++)
    {
        output.WriteLine($"{i:D2}{new string('*', data[i, column])}");
    }

    output.Close();
}