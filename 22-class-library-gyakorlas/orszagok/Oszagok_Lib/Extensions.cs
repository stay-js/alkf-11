namespace Oszagok_Lib
{
    public static class Extensions
    {
        public static IEnumerable<Country> ParseToCountries(this IEnumerable<string> lines)
        {
            return lines.Skip(1).Select(line =>
            {
                string[] parts = line.Split(';');

                return new Country(
                    parts[0],
                    uint.Parse(parts[1]),
                    uint.Parse(parts[2]),
                    parts[3],
                    uint.Parse(parts[4])
                    );
            });
        }

        public static long SumOfPopulation(this IEnumerable<Country> countries)
        {
            return countries.Sum(c => c.Population);
        }

        public static long SumOfArea(this IEnumerable<Country> countries)
        {
            return countries.Sum(c => c.Area);
        }

        public static double AvgDistanceFromBudapest(this IEnumerable<Country> countries)
        {
            return countries.Average(c => c.DistanceFromBudapest);
        }

        public static string BiggestCountry(this IEnumerable<Country> countries)
        {
            return countries.MaxBy(c => c.Area)!.Name;
        }

        public static string CapitalOfLeastPopulatedCountry(this IEnumerable<Country> countries)
        {
            return countries.MinBy(c => c.Population)!.Capital;
        }

        public static string FarthestCapitalFromBudapest(this IEnumerable<Country> countries)
        {
            return countries.MaxBy(c => c.DistanceFromBudapest)!.Capital;
        }

        public static int CountOfStartsWith(this IEnumerable<Country> countries, string toStartWith)
        {
            return countries.Count(c => c.Name.StartsWith(toStartWith));
        }

        public static Country? FindByCapital(this IEnumerable<Country> countries, string capital)
        {
            try
            {
                return countries.First(c =>
                    string.Equals(c.Capital, capital, StringComparison.CurrentCultureIgnoreCase));
            }
            catch
            {
                return null;
            }
        }

        public static IEnumerable<string> SmallerThan(this IEnumerable<Country> countries, uint area)
        {
            return countries.Where(c => c.Area < area).Select(c => c.Name);
        }

        public static void WriteSmallerThanToFile(this IEnumerable<Country> countries, uint area, string path)
        {
            File.WriteAllLines(path, countries.Where(c => c.Area < area).Select(c => c.ToString()));
        }
    }
}
