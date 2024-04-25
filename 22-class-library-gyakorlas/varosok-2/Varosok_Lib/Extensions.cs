namespace Varosok_Lib
{
    public static class Extensions
    {
        public static IEnumerable<City> ParseToCities(this IEnumerable<string> lines)
        {
            return lines.Skip(1).Select(line => new City(line));
        }

        public static double PopulationPerCountry(this IEnumerable<City> cities, string country)
        {
            return cities.Where(c => c.Country == country).Sum(c => c.Population);
        }

        public static bool ContainsCityFrom(this IEnumerable<City> cities, string country)
        {
            return cities.Any(c => c.Country == country);
        }

        public static IEnumerable<string> CitiesFrom(this IEnumerable<City> cities, string country)
        {
            return cities.Where(c => c.Country == country).Select(c => c.Name);
        }

        public static IEnumerable<string> Countries(this IEnumerable<City> cities)
        {
            return cities.Select(c => c.Country).Distinct();
        }

        public static void WriteTopToFile(this IEnumerable<City> cities, int amount, string path)
        {
            File.WriteAllLines(path,
                cities
                    .OrderByDescending(c => c.Population)
                    .Take(amount)
                    .Select(c => $"{c.Name} ({c.Country}): {c.PopulationInThousands} ezer fő")
            );
        }
    }
}
