#region 1.feladat
Print2dIntMatrix(Generate2dRandomIntMatrix());
#endregion

#region 2.feladat
Console.WriteLine();

GenerateAndPrintNamesMatrix();
#endregion

#region 3.feladat
Console.WriteLine();

Print2dJaggedVector(GenerateJaggedVector());
#endregion

#region 4.feladat
Console.WriteLine();

Print2dJaggedVector(GenerateJaggedVectorWithInit());
#endregion

#region 5. feladat
Print2dIntMatrix(GenerateNxNMatrix());
#endregion

#region 6. feladat
Print2dIntMatrix(GenerateContinuousMatrix());
#endregion

#region 7. feladat
PrintNxNMatrix(GenerateRandomNxNMatrix());
#endregion

static void Print2dIntMatrix(int[,] matrix)
{
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            Console.Write($"{matrix[y, x],4}");
        }

        Console.WriteLine();
    }
}


static void Print2dJaggedVector(int[][] vec)
{
    for (int y = 0; y < vec.Length; y++)
    {
        for (int x = 0; x < vec[y].Length; x++)
        {
            Console.Write($"{vec[y][x],4}");
        }

        Console.WriteLine();
    }
}

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

static void GenerateAndPrintNamesMatrix()
{
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



static int[,] GenerateNxNMatrix()
{
    Console.Write("\nAdja meg a mátrix méretét: ");
    int length = int.Parse(Console.ReadLine() ?? "");

    int[,] matrix = new int[length, length];

    for (int i = 0; i < length; i++)
    {
        matrix[i, i] = 1;
    }

    return matrix;
}

static int[,] GenerateContinuousMatrix()
{
    Console.Write("\nAdja meg a mátrix hosszát: ");
    int height = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Adja meg a mátrix szélességét: ");
    int width = int.Parse(Console.ReadLine() ?? "");

    int[,] matrix = new int[height, width];

    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            matrix[y, x] = x;
        }
    }

    return matrix;
}

static int[,] GenerateRandomNxNMatrix()
{
    Console.Write("\nAdja meg a mátrix hosszát: ");
    int width = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Adja meg a mátrix szélességét: ");
    int height = int.Parse(Console.ReadLine() ?? "");

    int[,] matrix = new int[width, height];

    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            matrix[y, x] = Random.Shared.Next(101);
        }
    }

    return matrix;
}

static void PrintNxNMatrix(int[,] matrix)
{
    int width = matrix.GetLength(0);
    int height = matrix.GetLength(1);

    Console.WriteLine("\nAll:");
    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            Console.Write($"{matrix[y, x],4}");
        }

        Console.WriteLine();
    }

    Console.WriteLine("\nMain diagonal:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine(matrix[i, i]);
    }

    Console.WriteLine("\nSecondary diagonal:");
    for (int y = 0, x = height - 1; y < width && x >= 0; y++, x--)
    {
        Console.WriteLine(matrix[y, x]);
    }

    Console.WriteLine("\nAbove main diagonal:");
    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            if (x > y)
            {
                Console.WriteLine(matrix[y, x]);
            }
        }
    }

    Console.WriteLine("\nBelow main diagonal:");
    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            if (x < y)
            {
                Console.WriteLine(matrix[y, x]);
            }
        }
    }

    Console.WriteLine("\nAbove secondary diagonal:");
    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            if (x < width - y - 1)
            {
                Console.WriteLine(matrix[y, x]);
            }
        }
    }

    Console.WriteLine("\nBelow secondary diagonal:");
    for (int y = 0; y < width; y++)
    {
        for (int x = 0; x < height; x++)
        {
            if (x >= width - y)
            {
                Console.WriteLine(matrix[y, x]);
            }
        }
    }
}