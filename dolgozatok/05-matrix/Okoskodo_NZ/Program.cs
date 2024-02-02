#region 1 - 3. feladat
string[] names = ReadNames();
int[,] scores = ReadScores();

int numberOfStudents = scores.GetLength(0);
int numberOfSubjects = scores.GetLength(1);

int spaceForName = LongestName() + 2;

int[] totalScorePerStudent = TotalScorePerStudent();
double[] avgScorePerSubject = AvgScorePerSubject();

Console.WriteLine("Eredmények:\n" +
    new string(' ', spaceForName) +
      string.Concat(Enumerable.Range(1, numberOfSubjects).Select(x => $"{x}.".PadRight(5))) +
    " Összesen:");

for (int i = 0; i < numberOfStudents; i++)
{
    Console.WriteLine(names[i].PadRight(spaceForName) +
        string.Concat(Enumerable.Range(0, numberOfSubjects).Select(x => $"{scores[i, x],-5}")) +
        $" {totalScorePerStudent[i]} pont");
}

Console.WriteLine("Átlag:".PadRight(spaceForName)
    + string.Join(' ', avgScorePerSubject.Select(x => $"{x:N2}")));
#endregion

#region 4. feladat
int maxScoreIdx = MaxScoreIdx();
Console.WriteLine($"\nA legmagasabb pontszámot {names[maxScoreIdx]} érte el," +
    $" összesen: {totalScorePerStudent[maxScoreIdx]} pontot.");
#endregion

#region 5. feladat
Console.WriteLine($"{AmountOfBooks()} jutalomkönyvet kell vásárolni.");
#endregion

#region 6. feladat
Console.WriteLine(LessThan5Points(out int idx, out int exerciseIdx)
    ? $"{names[idx]} a(z) {exerciseIdx + 1} feladatára 5 pontnál kevesebbet kapott."
    : "Nincs ilyen tanuló.");
#endregion

static string[] ReadNames()
{
    return File.ReadAllLines("nevek.txt").Skip(1).ToArray();
}

static int[,] ReadScores()
{
    string[] input = File.ReadAllLines("pontok.txt");
    int numberOfSubjects = input[0].Split(';').Length;
    int[,] scores = new int[input.Length, numberOfSubjects];

    for (int i = 0; i < input.Length; i++)
    {
        string[] line = input[i].Split(';');

        for (int j = 0; j < numberOfSubjects; j++)
        {
            scores[i, j] = int.Parse(line[j]);
        }
    }

    return scores;
}

int LongestName()
{
    int longestName = names[0].Length;

    for (int i = 1; i < names.Length; i++)
    {
        if (names[i].Length > longestName) longestName = names[i].Length;
    }

    return longestName;
}

int[] TotalScorePerStudent()
{
    int[] totalScores = new int[numberOfStudents];

    for (int i = 0; i < numberOfStudents; i++)
    {
        for (int j = 0; j < numberOfSubjects; j++)
        {
            totalScores[i] += scores[i, j];
        }
    }

    return totalScores;
}

double[] AvgScorePerSubject()
{
    double[] totalScoresPerSubject = new double[numberOfSubjects];

    for (int i = 0; i < numberOfStudents; i++)
    {
        for (int j = 0; j < numberOfSubjects; j++)
        {
            totalScoresPerSubject[j] += scores[i, j];
        }
    }

    return totalScoresPerSubject.Select(x => x / numberOfStudents).ToArray();
}

int MaxScoreIdx()
{
    int maxIdx = 0;

    for (int i = 0; i < numberOfStudents; i++)
    {
        if (totalScorePerStudent[i] > totalScorePerStudent[maxIdx]) maxIdx = i;
    }

    return maxIdx;
}

int AmountOfBooks()
{
    int books = 0;

    for (int i = 0; i < numberOfStudents; i++)
    {
        int j = 0;

        while (j < numberOfSubjects && scores[i, j] < 12)
        {
            j++;
        }

        if (j < numberOfSubjects) books++;
    }

    return books;
}

bool LessThan5Points(out int idx, out int exerciseIdx)
{
    bool exists = false;
    idx = -1;
    exerciseIdx = -1;

    for (int i = 0; !exists && i < numberOfStudents; i++)
    {
        for (int j = 0; !exists && j < numberOfSubjects; j++)
        {
            if (scores[i, j] >= 5) continue;

            exists = true;
            idx = i;
            exerciseIdx = j;
        }
    }

    return exists;
}
