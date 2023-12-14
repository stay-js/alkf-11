#region 1.feladat
int[,] numbers = Generate2dRandomIntMatrix();

for (int y = 0; y < numbers.GetLength(1); y++)
{
    for (int x = 0; x < numbers.GetLength(1); x++)
    {
        Console.Write($"{numbers[y, x],4}");
    }

    Console.WriteLine();
}
#endregion

#region 2.feladat
Console.WriteLine();

string[,] names = {
    { "Anna", "Béla", "Pista" },
    { "János", "Péter", "Viktor" },
    { "Gábor", "Marcell", "Zsepykesz" }
};

for (int y = 0; y < names.GetLength(0); y++)
{
    for (int x = 0; x < names.GetLength(0); x++)
    {
        Console.WriteLine($"{y + 1}. sor {x + 1}. eleme: {names[y, x]}");
    }
}
#endregion

#region 3.feladat
Console.WriteLine();

int[][] jaggedVector = GenerateJaggedVector();

foreach (int[] row in jaggedVector)
{
    Console.WriteLine(string.Join(" ", row));
}
#endregion

#region 4.feladat
Console.WriteLine();

jaggedVector = GenerateJaggedVectorWithInit();

foreach (int[] row in jaggedVector)
{
    Console.WriteLine(string.Join(" ", row));
}
#endregion

#region 5. feladat
PrintNxNMatrix();
#endregion

#region 6. feladat
ContinuousMatrix();
#endregion

#region 7. feladat
GenerateAndPrintNxNMatrix();
#endregion

static int[,] Generate2dRandomIntMatrix()
{
    Console.Write("Adja meg a mátrix hosszát: ");
    int height = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Adja meg a mátrix szélességét: ");
    int width = int.Parse(Console.ReadLine() ?? "");

    int[,] numbers = new int[height, width];

    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            numbers[y, x] = Random.Shared.Next(101);
        }
    }

    return numbers;
}

static int[] GenerateRow()
{
    int length = Random.Shared.Next(3, 10);
    return Enumerable.Range(0, length).Select(_ => Random.Shared.Next(10)).ToArray();
}

static int[][] GenerateJaggedVector()
{
    int[][] vec = new int[6][];

    for (int i = 0; i < vec.Length; i++)
    {
        vec[i] = GenerateRow();
    }

    return vec;
}

static int[][] GenerateJaggedVectorWithInit()
{
    return [
        GenerateRow(),
        GenerateRow(),
        GenerateRow(),
        GenerateRow(),
        GenerateRow(),
        GenerateRow()
    ];
}

static void PrintNxNMatrix()
{
    Console.Write("\nAdja meg a mátrix méretét: ");
    int length = int.Parse(Console.ReadLine() ?? "");

    int[,] matrix = new int[length, length];

    for (int i = 0; i < length; i++)
    {
        matrix[i, i] = 1;
    }

    for (int y = 0; y < length; y++)
    {
        for (int x = 0; x < length; x++)
        {
            Console.Write($"{matrix[y, x],2}");
        }

        Console.WriteLine();
    }
}

static void ContinuousMatrix()
{
    Console.Write("\nAdja meg a mátrix hosszát: ");
    int height = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Adja meg a mátrix szélességét: ");
    int width = int.Parse(Console.ReadLine() ?? "");

    int[,] numbers = new int[height, width];

    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            numbers[y, x] = x;
        }
    }

    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            Console.Write($"{numbers[y, x],2}");
        }

        Console.WriteLine();
    }
}

static void GenerateAndPrintNxNMatrix()
{
    Console.Write("\nAdja meg a mátrix hosszát: ");
    int width = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Adja meg a mátrix szélességét: ");
    int height = int.Parse(Console.ReadLine() ?? "");

    int[,] numbers = new int[width, height];

    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            numbers[y, x] = Random.Shared.Next(101);
        }
    }

    Console.WriteLine("\nAll:");
    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            Console.Write($"{numbers[y, x],4}");
        }

        Console.WriteLine();
    }

    Console.WriteLine("\nMain diagonal:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        Console.WriteLine(numbers[i, i]);
    }

    Console.WriteLine("\nSecondary diagonal:");
    for (int y = 0, x = height - 1; y < width && x >= 0; y++, x--)
    {
        Console.WriteLine(numbers[y, x]);
    }
}