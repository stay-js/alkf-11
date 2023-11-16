var input = new StreamReader("valaszok.txt");

int days = int.Parse(input.ReadLine() ?? "");
int hard = int.Parse(input.ReadLine() ?? "");
int easy = int.Parse(input.ReadLine() ?? "");

int[] data = new int[days];
int i = 0;

while(i < days && !input.EndOfStream)
{
    data[i++] = int.Parse(input.ReadLine() ?? "");
}

input.Close();

for(i = 0; i < data.Length; i++)
{
    Console.WriteLine($"{i + 1}. nap: {data[i]} helyes válasz - {Difficulty(data[i])}");
}

Console.Write($"\nKiemelkedő nehézségű feladatok: ");
for (i = 0; i < data.Length - 1; i++)
{
    if ((i == 0 || Difficulty(data[i - 1]) == "könnyű")
        && Difficulty(data[i]) == "nehéz"
        && Difficulty(data[i + 1]) == "könnyű")
    {
        Console.Write($"{i + 1} ");
    }
}


string Difficulty(int correctAnswers)
{
    if (correctAnswers > easy) return "könnyű";
    else if (correctAnswers > hard) return "közepes";
    return "nehéz";
}