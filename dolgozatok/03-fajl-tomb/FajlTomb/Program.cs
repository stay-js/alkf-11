var input = new StreamReader("valaszok.txt");

int days = int.Parse(input.ReadLine() ?? "");
int hard = int.Parse(input.ReadLine() ?? "");
int easy = int.Parse(input.ReadLine() ?? "");

var data = new (int, string)[days];

for (int i = 0; i < data.Length && !input.EndOfStream; i++)
{
    int correctAnswers = int.Parse(input.ReadLine() ?? "");
    data[i] = (correctAnswers, Difficulty(correctAnswers, hard, easy));
}

input.Close();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine($"{i + 1}. nap: {data[i].Item1} helyes válasz - {data[i].Item2}");
}

Console.Write($"\nKiemelkedő nehézségű feladatok: ");
for (int i = 0; i < data.Length - 1; i++)
{
    if ((i == 0 || data[i - 1].Item2 == "könnyű")
        && data[i].Item2 == "nehéz"
        && data[i + 1].Item2 == "könnyű")
    {
        Console.Write($"{i + 1} ");
    }
}

static string Difficulty(int correctAnswers, int hard, int easy)
{
    if (correctAnswers > easy) return "könnyű";
    else if (correctAnswers > hard) return "közepes";
    return "nehéz";
}