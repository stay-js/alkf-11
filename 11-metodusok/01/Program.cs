using System.Text;

uint a, b;
ConsoleColor color;

do Console.Write("Adja meg az \"a\" oldalt (természetes szám): ");
while (!uint.TryParse(Console.ReadLine(), out a));

do Console.Write("Adja meg a \"b\" oldalt (természetes szám): ");
while (!uint.TryParse(Console.ReadLine(), out b));

Console.Write("Adjon meg egy színt: ");
string input = (Console.ReadLine() ?? "").ToLower() switch
{
    "fekete" => "0",
    "sötétkék" => "1",
    "sötétzöld" => "2",
    "sötétkékzöld" => "3",
    "sötétpiros" => "4",
    "sötétlila" => "5",
    "sötétsárga" => "6",
    "szürke" => "7",
    "sötétszürke" => "8",
    "kék" => "9",
    "zöld" => "10",
    "cián" => "11",
    "piros" => "12",
    "lila" => "13",
    "sárga" => "14",
    "fehér" => "15",

    "black" => "0",
    "darkblue" => "1",
    "darkgreen" => "2",
    "darkcyan" => "3",
    "darkred" => "4",
    "darkmagenta" => "5",
    "darkyellow" => "6",
    "gray" => "7",
    "darkgray" => "8",
    "blue" => "9",
    "green" => "10",
    "cyan" => "11",
    "red" => "12",
    "magenta" => "13",
    "yellow" => "14",
    "white" => "15",

    string x => x,
};

TeglalapRajzolo(a, b, Enum.TryParse(input, out color) ? color : ConsoleColor.White);

static void TeglalapRajzolo(uint aOldal, uint bOldal, ConsoleColor szin)
{
    var toPrint = new StringBuilder();

    for (int i = 0; i < aOldal; i++)
    {
        toPrint.Append('#');

        for (int j = 0; j < bOldal - 2; j++)
        {
            toPrint.Append(i == 0 || i == bOldal - 1 ? " #" : "  ");
        }

        toPrint.Append(" #\n");
    }

    Console.ForegroundColor = szin;
    Console.Write($"\n{toPrint}");
    Console.ResetColor();
}