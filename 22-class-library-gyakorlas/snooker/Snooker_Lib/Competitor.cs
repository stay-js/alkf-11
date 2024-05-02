namespace Snooker_Lib
{
    public class Competitor
    {
        public int Place { get; init; }
        public string Name { get; init; }
        public string Country { get; init; }
        public int Award { get; init; }

        public int AwardInHuf => Award * 380;

        public Competitor(string input)
        {
            string[] parts = input.Split(';');

            Place = int.Parse(parts[0]);
            Name = parts[1];
            Country = parts[2];
            Award = int.Parse(parts[3]);
        }

        public string InfoWithAwardInHuf()
        {
            return $"\tHelyezés: {Place}" +
                $"\n\tNév: {Name}" +
                $"\n\tNyeremény: {AwardInHuf} Ft";
        }

        public override string ToString()
        {
            return $"\tNév: {Name}" +
                $"\n\tOrszág: {Country}" +
                $"\n\tNyeremény: {Award} font";
        }
    }
}
