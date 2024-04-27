using System.Text;

namespace Varosok_Lib
{
    public static class Cities
    {
        public static IEnumerable<City> Parse(IEnumerable<string> lines)
        {
            return lines.Skip(1).Select(line => new City(line));
        }

        public static City FirstLowerThan(this IEnumerable<City> cities, uint population)
        {
            return cities.First(c => c.Population < population);
        }

        public static double AvgArea(this IEnumerable<City> cities)
        {
            return Math.Round(cities.Average(c => c.Area), 2);
        }

        public static int CountBecameCityLaterThan(this IEnumerable<City> cities, uint year)
        {
            return cities.Count(c => c.YearOfDeclaration > year);
        }

        public static bool HaveCitiesBeenDeclaredInYear(this IEnumerable<City> cities, uint year)
        {
            return cities.Any(c => c.YearOfDeclaration == year);
        }

        public static string TopCities(this IEnumerable<City> cities, string county, int amount)
        {
            var toReturn = new StringBuilder($"A {amount} legsűrűbben lakott {county} vármegyei város:");

            var selectedCities = cities
                .Where(c => c.County == county)
                .OrderByDescending(c => c.PopulationDensity)
                .Take(amount);

            for (int i = 0; i < amount; i++)
            {
                toReturn.Append($"\n\t{i + 1}. {selectedCities.ElementAt(i).Name}");
            }

            return toReturn.ToString();
        }

        public static IEnumerable<string> CitiesInCounty(this IEnumerable<City> cities, string county)
        {
            return cities.Where(c => c.County == county).Select(c => c.Name).Order();
        }

        public static IEnumerable<string> AmountOfCitiesPerCounty(this IEnumerable<City> cities)
        {
            return cities.GroupBy(c => c.County).Select(group => $"\t{group.Key}: {group.Count()}");
        }
    }
}
