#region 1. feladat
var (students, grades) = ReadData();

int length = grades.GetLength(0);
int numberOfSubjects = grades.GetLength(1);
#endregion

#region 2. feladat
Console.WriteLine($"{students.Length} tanuló adatát olvastuk be.\n");
#endregion

#region 3. feladat
double[] averages = CalculateAverages();

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"{students[i]}: {averages[i]:N2}");
}
#endregion

#region 4. feladat
Console.WriteLine($"\n{students[LowestAvg()]} átlaga a legalacsonyabb.");
#endregion

#region 5. feladat
Console.WriteLine($"{students[HighestAvg()]} átlaga a legmagasabb.");
#endregion

#region 6. feladat
double[] avgPerSubject = AvgPerSubject();

Console.WriteLine("\nTantárgyankénti átlagok:" +
    $"\n\t- Magyar: {avgPerSubject[0]:N2}" +
    $"\n\t- Matematika: {avgPerSubject[1]:N2}" +
    $"\n\t- Történelem: {avgPerSubject[2]:N2}" +
    $"\n\t- Angol: {avgPerSubject[3]:N2}" +
    $"\n\t- Informatika: {avgPerSubject[4]:N2}");
#endregion

#region 7. feladat
Console.WriteLine($"\n5-ös érdemjegyek száma: {CountExcellent()}");
#endregion

#region 8. feladat
int[] aboveAvgPerSubject = CountAboveAvgPerSubject();

Console.WriteLine("\nÁtlag feletti érdemjegyek száma tantárgynként:" +
    $"\n\t- Magyar: {aboveAvgPerSubject[0]}" +
    $"\n\t- Matematika: {aboveAvgPerSubject[1]}" +
    $"\n\t- Történelem: {aboveAvgPerSubject[2]}" +
    $"\n\t- Angol: {aboveAvgPerSubject[3]}" +
    $"\n\t- Informatika: {aboveAvgPerSubject[4]}");
#endregion

#region 9. feladat
Console.WriteLine($"\n{CountBetterInMathsThenPrevious()} olyan tanuló van aki jobb érdemjegyet" +
    "szerzett matematikából, mint az előtte álló tanuló.");
#endregion

#region 10. feladat
int[] indexes = StudentsWithSpecifiedGrade();

Console.WriteLine("\nA megadott érdemjeggyel rendelkező tanulók:");
foreach (int index in indexes)
{
    Console.WriteLine(students[index]);
}
#endregion

#region 11. feladat
Console.WriteLine("\nTanulók, akik legalább egy tantárgyból megbuktak:");
PrintData(StudentsWhoFailed());
#endregion

static (string[], int[,]) ReadData()
{
    string[] input = File.ReadAllLines("adatok.csv");

    string[] students = new string[input.Length];
    int[,] grades = new int[input.Length, input[0].Split(';').Length - 1];

    for (int i = 0; i < input.Length; i++)
    {
        string[] parts = input[i].Split(';');
        students[i] = parts[0];

        for (int j = 1; j < parts.Length; j++)
        {
            grades[i, j - 1] = int.Parse(parts[j]);
        }
    }

    return (students, grades);
}

double[] CalculateAverages()
{
    double[] averages = new double[length];

    for (int i = 0; i < length; i++)
    {
        double sum = 0;

        for (int j = 0; j < numberOfSubjects; j++)
        {
            sum += grades[i, j];
        }

        averages[i] = sum / numberOfSubjects;
    }

    return averages;
}

int LowestAvg()
{
    int minIdx = 0;

    for (int i = 0; i < length; i++)
    {
        if (averages[i] < averages[minIdx]) minIdx = i;
    }

    return minIdx;
}

int HighestAvg()
{
    int maxIdx = 0;

    for (int i = 0; i < length; i++)
    {
        if (averages[i] > averages[maxIdx]) maxIdx = i;
    }

    return maxIdx;
}

double[] AvgPerSubject()
{
    double[] averages = new double[numberOfSubjects];

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < numberOfSubjects; j++)
        {
            averages[j] += grades[i, j];
        }
    }

    for (int i = 0; i < numberOfSubjects; i++)
    {
        averages[i] /= length;
    }

    return averages;
}

int CountExcellent()
{
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < numberOfSubjects; j++)
        {
            if (grades[i, j] == 5) count++;
        }
    }

    return count;
}

int[] CountAboveAvgPerSubject()
{
    int[] counts = new int[numberOfSubjects];

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < numberOfSubjects; j++)
        {
            if (grades[i, j] > avgPerSubject[j]) counts[j]++;
        }
    }

    return counts;
}

int CountBetterInMathsThenPrevious()
{
    int count = 0;

    for (int i = 1; i < length; i++)
    {
        if (grades[i, 1] > grades[i - 1, 1]) count++;
    }

    return count;
}

int[] StudentsWithSpecifiedGrade()
{
    int query;

    do Console.Write("Adja meg a keresett érdemjegyet (1-5): ");
    while (!int.TryParse(Console.ReadLine(), out query) || query < 1 || query > 5);

    int[] indexes = new int[length];
    int len = 0;

    for (int i = 0; i < length; i++)
    {
        int j = 0;

        while (j < numberOfSubjects && grades[i, j] != query)
        {
            j++;
        }

        if (j < numberOfSubjects) indexes[len++] = i;
    }

    Array.Resize(ref indexes, len);

    return indexes;
}

int[] StudentsWhoFailed()
{
    int[] indexes = new int[length];
    int len = 0;

    for (int i = 0; i < length; i++)
    {
        int j = 0;

        while (j < numberOfSubjects && grades[i, j] != 1)
        {
            j++;
        }

        if (j < numberOfSubjects) indexes[len++] = i;
    }

    Array.Resize(ref indexes, len);

    return indexes;
}

void PrintData(int[] indexes)
{
    Console.WriteLine($"{"Név",-20} {"Magyar",15} {"Matematika",15} {"Történelem",15}" +
        $" {"Angol",15} {"Informatika",15} {"Átlag",15}");

    foreach (int i in indexes)
    {
        Console.WriteLine($"{students[i],-20} {grades[i, 0],15} {grades[i, 1],15}" +
            $" {grades[i, 2],15} {grades[i, 3],15} {grades[i, 4],15} {averages[i],15}");
    }
}