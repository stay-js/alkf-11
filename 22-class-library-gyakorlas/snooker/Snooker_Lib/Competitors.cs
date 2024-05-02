namespace Snooker_Lib
{
    public static class Competitors
    {
        public static IEnumerable<Competitor> Parse(IEnumerable<string> lines)
        {
            return lines.Skip(1).Select(line => new Competitor(line));
        }

        public static Competitor FirstPlace(this IEnumerable<Competitor> competitors)
        {
            return competitors.First(c => c.Place == 1);
        }

        public static int CountFirstNameStartsWith(this IEnumerable<Competitor> competitors, string toStartWith)
        {
            return competitors.Count(c => c.Name.Split()[^1].StartsWith(toStartWith));
        }

        public static double AvgAward(this IEnumerable<Competitor> competitors)
        {
            return competitors.Average(c => c.Award);
        }

        public static int CountNotFrom(this IEnumerable<Competitor> competitors, string country)
        {
            return competitors.Count(c =>
                !string.Equals(c.Country, country, StringComparison.CurrentCultureIgnoreCase));
        }

        public static Competitor? HighestPaidFrom(this IEnumerable<Competitor> competitors, string country)
        {
            return competitors
                .Where(c => string.Equals(c.Country, country, StringComparison.CurrentCultureIgnoreCase))
                .MaxBy(c => c.Award);
        }

        public static bool ExistsFrom(this IEnumerable<Competitor> competitors, string country)
        {
            return competitors.Any(c =>
                string.Equals(c.Country, country, StringComparison.CurrentCultureIgnoreCase));
        }

        public static IEnumerable<string> TopFrom(this IEnumerable<Competitor> competitors, int amount, string country)
        {
            return competitors
                .Where(c => string.Equals(c.Country, country, StringComparison.CurrentCultureIgnoreCase))
                .OrderBy(c => c.Place)
                .Select(c => c.Name)
                .Take(amount);
        }

        public static IEnumerable<string> Countries(this IEnumerable<Competitor> competitors)
        {
            return competitors.Select(c => c.Country).Distinct().Order();
        }

        public static IEnumerable<string> CompetitorsFrom(this IEnumerable<Competitor> competitors, string country)
        {
            return competitors
                .Where(c => string.Equals(c.Country, country, StringComparison.CurrentCultureIgnoreCase))
                .Select(c => c.Name)
                .Order();
        }
    }
}
