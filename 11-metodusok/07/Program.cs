﻿Console.Write("Adjon meg egy szólistát, a szavakat vesszővel és szőközzel válassza el: ");
string[] words = (Console.ReadLine() ?? "").Split(", ");

Console.WriteLine(ReversedUppercase(words));

static string ReversedUppercase(string[] words)
{
    return string.Join(' ', words.Select(word => char.ToUpper(word[0]) + word[1..]).Reverse());
}