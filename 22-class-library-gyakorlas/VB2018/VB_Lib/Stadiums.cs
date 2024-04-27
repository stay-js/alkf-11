namespace VB_Lib
{
    public static class Stadiums
    {
        public static IEnumerable<Stadium> Parse(IEnumerable<string> lines)
        {
            return lines.Skip(1).Select(line => new Stadium(line));
        }

        public static double AvgCapacity(this IEnumerable<Stadium> stadiums)
        {
            return Math.Round(stadiums.Average(s => s.Capacity), 1);
        }

        public static int CountAlternativeName(this IEnumerable<Stadium> stadiums)
        {
            return stadiums.Count(s => s.Name2 is not null);
        }

        public static int CountWhereNameContains(this IEnumerable<Stadium> stadiums, string toContain)
        {
            return stadiums.Count(s => s.Name.Contains(toContain));
        }

        public static IEnumerable<string> Cities(this IEnumerable<Stadium> stadiums)
        {
            return stadiums.Select(s => s.City).Distinct().Order();
        }

        public static void WriteToFile(this IEnumerable<Stadium> stadiums, string path)
        {
            File.WriteAllLines(path,
                stadiums.Select(s => string.Join(';', s.Name, s.Name2, s.Capacity))
                );
            Console.WriteLine("A fájlba írás sikeresen megtörtént!");
        }
    }
}
