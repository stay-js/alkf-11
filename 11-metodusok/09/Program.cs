Console.Write("Adjon meg egy számlistát, a számokat vesszővel és szőközzel válassza el: ");
int[] numbers = (Console.ReadLine() ?? "").Split(", ").Select((x) => Convert.ToInt32(x)).ToArray();

Console.WriteLine($"{CountNumbersWithinRange(numbers)} olyan szám van ami az értékek átlagától maximum 10-el tér el.");


static int CountNumbersWithinRange(int[] numbers)
{
    double avg = numbers.Average();
    int count = 0;

    foreach(int number in numbers)
    {
        if(Math.Abs(number - avg) <= 10) count++;
    }

    return count;
}