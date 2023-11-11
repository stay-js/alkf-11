using System;

int length = int.Parse(Console.ReadLine() ?? "");
(string, int)[] data = new (string, int)[length];

for (int i = 0; i < length; i++)
{
    string[] line = (Console.ReadLine() ?? "").Split();
    data[i] = (line[0], int.Parse(line[1]));
}

int j = 0;
while (j < length && data[j] != ("Szekszard", -1))
{
    j++;
}

Console.WriteLine(j < length ? "VAN" : "NINCS");