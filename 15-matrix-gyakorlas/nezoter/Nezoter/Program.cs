using System.Text;

const int ROWS = 15;
const int COLUMNS = 20;

#region 1. feladat
bool[,] occupancy = ReadOccupancy();
int[,] categories = ReadCategories();
#endregion

#region 2. feladat
Console.WriteLine("2. feladat");
Console.WriteLine($"Az ön által megadott szék {(IsOccupied() ? "foglalt" : "szabad")}.");
#endregion

#region 3. feladat
Console.WriteLine("\n3. feladat");

int sold = CountSoldTickets();
Console.WriteLine($"Az előadásra eddig {sold} jegyet adtak el, ez a nézőtér " +
    $"{Convert.ToDouble(sold) / Convert.ToDouble(ROWS * COLUMNS):P2}-a.");
#endregion

#region 4. feladat
Console.WriteLine("\n4. feladat");
Console.WriteLine($"A legtöbb jegyet a(z) {MostSoldCategory()}. árkategóriában értékesítették.");
#endregion

#region 5. feladat
Console.WriteLine("\n5. feladat");
Console.WriteLine($"{CalculateIncome():C0} lenne a színház bevétele a pillanatnyilag eladott jegyek alapján.");
#endregion

#region 6. feladat
Console.WriteLine("\n6. feladat");
Console.WriteLine($"{StandaloneEmptySeats()} egyedülálló üres hely van a nézőtéren.");
#endregion

#region 7. feladat
WriteDataToFile();
#endregion

static bool[,] ReadOccupancy()
{
    bool[,] occupancy = new bool[ROWS, COLUMNS];
    var input = new StreamReader("foglaltsag.txt");

    for (int i = 0; i < ROWS && !input.EndOfStream; i++)
    {
        string row = input.ReadLine() ?? "";

        for (int j = 0; j < COLUMNS; j++)
        {
            occupancy[i, j] = row[j] == 'x';
        }
    }

    input.Close();

    return occupancy;
}

static int[,] ReadCategories()
{
    int[,] categories = new int[ROWS, COLUMNS];
    var input = new StreamReader("kategoria.txt");

    for (int i = 0; i < ROWS && !input.EndOfStream; i++)
    {
        string row = input.ReadLine() ?? "";

        for (int j = 0; j < COLUMNS; j++)
        {
            categories[i, j] = row[j] - '0';
        }
    }

    input.Close();

    return categories;
}

bool IsOccupied()
{
    int row, column;

    do Console.Write("Adjon meg egy sor számot: ");
    while (!int.TryParse(Console.ReadLine(), out row));

    do Console.Write("Adjon meg egy szék számot: ");
    while (!int.TryParse(Console.ReadLine(), out column));

    return occupancy[row - 1, column - 1];
}

int CountSoldTickets()
{
    int count = 0;

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            if (occupancy[i, j]) count++;
        }
    }

    return count;
}

int MostSoldCategory()
{
    int[] counts = new int[5];

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            if (occupancy[i, j]) counts[categories[i, j] - 1]++;
        }
    }

    int max = 0;

    for (int i = 1; i < counts.Length; i++)
    {
        if (counts[i] > counts[max]) max = i;
    }

    return max + 1;
}

int CalculateIncome()
{
    int total = 0;

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            if (!occupancy[i, j]) continue;

            total += categories[i, j] switch
            {
                1 => 5000,
                2 => 4000,
                3 => 3000,
                4 => 2000,
                5 => 1500,
                _ => 0
            };
        }
    }

    return total;
}

int StandaloneEmptySeats()
{
    int standaloneEmptySeats = 0;

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            if (j == 0 && occupancy[i, j + 1]) standaloneEmptySeats++;
            else if (j == COLUMNS - 1 && occupancy[i, j - 1]) standaloneEmptySeats++;
            else if (j != 0 && j != COLUMNS - 1
                && !occupancy[i, j] && occupancy[i, j - 1] && occupancy[i, j + 1])
            {
                standaloneEmptySeats++;
            }
        }
    }

    return standaloneEmptySeats;
}

void WriteDataToFile()
{
    var output = new StreamWriter("szabad.txt");

    for (int i = 0; i < ROWS; i++)
    {
        var toPrint = new StringBuilder();

        for (int j = 0; j < COLUMNS; j++)
        {
            toPrint.Append(occupancy[i, j] ? categories[i, j].ToString() : 'x');
        }

        output.WriteLine(toPrint);
    }

    output.Close();
}