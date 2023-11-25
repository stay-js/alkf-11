#region 1.feladat
Console.Write("Adja meg az osztály létszámát: ");
int numberOfStudents = int.Parse(Console.ReadLine() ?? "");

//int[] grades = Enumerable.Range(0, numberOfStudents).Select(_ => Random.Shared.Next(2, 6)).ToArray();
int[] grades = new int[numberOfStudents];

for (int i = 0; i < grades.Length; i++)
{
    grades[i] = Random.Shared.Next(2, 6);
}

Console.WriteLine($"Érdemjegyek: {string.Join(", ", grades)}");
#endregion

#region 2.feladat
int[] categories = [1000, 1500, 2000, 2500, 3500];

Console.WriteLine("\nKategóriák: ");
foreach (int category in categories)
{
    Console.WriteLine($"\t- Eredeti ár: {category}, akciós ár: {category * 0.85}");
}
#endregion

#region 3.feladat
int[] throws = Enumerable.Range(1, 50).Select(_ => Random.Shared.Next(1, 7)).ToArray();

var output = new StreamWriter("dobasok.txt");

foreach (int thr in throws)
{
    output.WriteLine(thr + (thr == 6 ? " Újra dobhat!" : ""));
}

output.Close();
#endregion

#region 4.feladat
//string[] students = File.ReadAllLines("diakok.txt");
var input = new StreamReader("diakok.txt");

string[] students = new string[17];
int count = 0;

while (count < students.Length && !input.EndOfStream)
{
    students[count++] = (input.ReadLine() ?? "").Trim();
}

input.Close();

Console.WriteLine($"\nA kisorsolt tanuló: {students[Random.Shared.Next(students.Length - 1)]}");
#endregion

#region 5.feladat
string[] responses = File.ReadAllLines("valaszok.txt");

Console.Write("\nAdja meg a válasz sorszámát (1-5): ");
Console.WriteLine(responses[int.Parse(Console.ReadLine() ?? "") - 1]);
#endregion

#region 6.feladat
Console.Write("\nAdjon meg egy számot (min 3): ");
int max = int.Parse(Console.ReadLine() ?? "");

int[] fib = new int[max];

fib[0] = 0;
fib[1] = 1;

for (int i = 2; i < max; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}

Console.WriteLine($"Az első {max} fibonacci szám: {string.Join(", ", fib)}");
#endregion

#region 7.feladat
int[] binary = Enumerable.Range(0, 10).Select(_ => Random.Shared.Next(2)).ToArray();
int[] decimalValues = [512, 256, 128, 64, 32, 16, 8, 4, 2, 1];
int[] value = new int[10];

Console.WriteLine($"\nBináris érték: {string.Concat(binary)}");

for (int i = 0; i < 10; i++)
{
    value[i] = binary[i] == 1 ? decimalValues[i] : 0;
    Console.WriteLine($"{binary[i]} -> {(binary[i] == 1 ? decimalValues[i] : 0)}");
}

Console.WriteLine($"{string.Join(" + ", value)} = {value.Sum()}");
#endregion

#region 8.feladat
Console.WriteLine();

double[] speedRecords = new double[6];

for (int i = 0; i < speedRecords.Length; i++)
{
    Console.Write("Adjon meg egy sebességet: ");
    speedRecords[i] = double.Parse(Console.ReadLine() ?? "");
}

speedRecords = speedRecords.Select(x => x * 0.9).ToArray();

Console.WriteLine("\nSebesség értékek: ");
foreach (double record in speedRecords)
{
    Console.WriteLine($"{record} km/h{(record > 65 ? " - büntetés" : "")}");
}
#endregion

#region 9.feladat
bool[] doors = Enumerable.Range(0, 100).Select(_ => false).ToArray();

for (int i = 0; i <= doors.Length; i++)
{
    for (int j = i; j < doors.Length; j += i + 1)
    {
        doors[j] = !doors[j];
    }
}

output = new StreamWriter("ajtok.txt");

for (int i = 0; i < doors.Length; i++)
{
    output.WriteLine($"{i + 1}. ajtó: {(doors[i] ? "nyitva" : "zárva")}.");
}

output.Close();
#endregion

#region 10.feladat
Console.WriteLine();

int[] pin = Enumerable.Range(0, 6).Select(_ => Random.Shared.Next(10)).ToArray();

for (int i = 0; i < pin.Length; i++)
{
    Console.WriteLine($"{i + 1}. számjegy: {pin[i]}");
}
#endregion