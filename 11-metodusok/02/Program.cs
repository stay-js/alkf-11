using System.Text;

int oldal;

do Console.Write("Adja meg a rombusz magasságát (páratlan természetes szám): ");
while (!int.TryParse(Console.ReadLine(), out oldal) || oldal < 0 || oldal % 2 == 0);

RombuszRajzolo(oldal);

static void RombuszRajzolo(int oldal)
{
    var toPrint = new StringBuilder();

    for (int i = 0; i < oldal / 2; i++)
    {
        for (int j = 0; j < (oldal / 2) - i; j++)
        {
            toPrint.Append(' ');
        }

        for (int j = 0; j < (2 * i) + 1; j++)
        {
            toPrint.Append(j == 0 || j == 2 * i ? '*' : ' ');
        }

        toPrint.Append('\n');
    }

    for (int i = oldal / 2; i >= 0; i--)
    {
        for (int j = 0; j < (oldal / 2) - i; j++)
        {
            toPrint.Append(' ');
        }

        for (int j = 0; j < (2 * i) + 1; j++)
        {
            toPrint.Append(j == 0 || j == 2 * i ? '*' : ' ');
        }

        toPrint.Append('\n');
    }

    Console.Write($"\n{toPrint}");
}