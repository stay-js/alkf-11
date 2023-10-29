Random random = new Random();

#region 1.feladat
Console.Write("Adja meg az osztály létszámát: ");
int numberOfStudents = Convert.ToInt32(Console.ReadLine());

// int[] grades = Enumerable.Range(0, numberOfStudents).Select((_) => random.Next(2, 6)).ToArray();

int[] grades = new int[numberOfStudents];
for (int i = 0; i < grades.Length; i++)
{
    grades[i] = random.Next(2, 6);
}

Console.WriteLine($"Érdemjegyek: {string.Join(", ", grades)}");
#endregion

#region 2.feladat
int[] categories = new int[] { 1000, 1500, 2000, 2500, 3500 };

Console.WriteLine("\nKategóriák: ");
foreach (int category in categories)
{
    Console.WriteLine($"\t- Eredeti ár: {category}, akciós ár: {category * 0.85}");
}
#endregion

#region 3.feladat
int[] throws = Enumerable.Range(1, 50).Select((_) => random.Next(1, 7)).ToArray();
StreamWriter throwsOutput = new StreamWriter("dobasok.txt");

foreach (int thr in throws)
{
    throwsOutput.WriteLine(thr + (thr == 6 ? " Újra dobhat!" : ""));
}

throwsOutput.Close();
#endregion

#region 4.feladat
const int NUMBER_OF_STUDENTS = 17;

//string[] students = File.ReadAllLines("diakok.txt");

StreamReader studentsReader = new StreamReader("diakok.txt");

string[] students = new string[NUMBER_OF_STUDENTS];
int count = 0;

while(count < NUMBER_OF_STUDENTS && !studentsReader.EndOfStream)
{
    students[count] = (studentsReader.ReadLine() ?? "").Trim();
    count++;
}

studentsReader.Close();

Console.WriteLine($"\nA kisorsolt tanuló: {students[random.Next(0, students.Length - 1)]}");
#endregion

#region 5.feladat
string[] responses = new string[] { "Dolgozunk a probléma megoldásán, türelmüket kérjük.",
    "Ez a funkció csak a következő verzióban lesz elérhető.",
    "Kipróbáltuk, nekünk működik. Kérjük, olvassa el figyelmesebben a dokumentációt!",
    "Ez a funkció technikai okok miatt nem megvalósítható.",
    "Kérjük, pontosítsa a hibabejelentését, a hibajelenségről küldjön egy képernyő képet is!" };

Console.Write("\nAdja meg a válasz sorszámát: ");
Console.WriteLine(responses[Convert.ToInt32(Console.ReadLine()) - 1]);
#endregion

#region 6.feladat
Console.Write("\nAdjon meg egy számot: ");
int max = Convert.ToInt32(Console.ReadLine());

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
int[] binary = Enumerable.Range(0, 10).Select((_) => random.Next(2)).ToArray();
int[] decimalValues = new int[] { 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
int[] value = new int[10];

Console.WriteLine(string.Concat(binary));

for (int i = 0; i < 10; i++)
{
    value[i] = binary[i] == 1 ? decimalValues[i] : 0;
    Console.WriteLine($"{binary[i]} -> {(binary[i] == 1 ? decimalValues[i] : 0)}");
}

Console.WriteLine($"{string.Join(" + ", value)} = {value.Sum()}");
#endregion

#region 8.feladat
Console.WriteLine();

const int AMOUNT_OF_RECORDS = 6;
double[] speedRecords = new double[AMOUNT_OF_RECORDS];

for (int i = 0; i < AMOUNT_OF_RECORDS; i++)
{
    Console.Write("Adjon meg egy sebességet: ");
    speedRecords[i] = Convert.ToDouble(Console.ReadLine());
}

speedRecords = speedRecords.Select((val) => val * 0.9).ToArray();

Console.WriteLine("\nSebesség értékek: ");
foreach(double record in speedRecords)
{
    Console.WriteLine($"{record} km/h{(record > 65 ? " - büntetés" : "")}");
}
#endregion

#region 9.feladat
bool[] doors = Enumerable.Range(0, 100).Select((_) => false).ToArray();

for (int i = 0; i <= doors.Length; i++)
{
    for (int j = i; j < doors.Length; j += i + 1)
    {
        doors[j] = !doors[j];
    }
}

StreamWriter doorsOutput = new StreamWriter("doors.txt");

for (int i = 0; i < doors.Length; i++)
{
    doorsOutput.WriteLine($"{i + 1}. ajtó: {(doors[i] ? "nyitva": "zárva")}.");
}

doorsOutput.Close();
#endregion

#region 10.feladat
Console.WriteLine();
int[] pin = Enumerable.Range(0, 6).Select((_) => random.Next(10)).ToArray();

for (int i = 0; i < pin.Length; i++)
{
    Console.WriteLine($"{i + 1}. számjegy: {pin[i]}");
}
#endregion