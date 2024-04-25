namespace Varosok_Lib
{
    public class City
    {
        public string Name { get; init; }
        public string Country { get; init; }
        public double Population { get; init; }

        public double PopulationInThousands => Population / 1_000;
        public double PopulationInMillions => Population / 1_000_000;

        public City(string input)
        {
            string[] parts = input.Split(';');

            Name = parts[0];
            Country = parts[1];
            Population = double.Parse(parts[2]) * 1_000_000;
        }

        public override string ToString()
        {
            return $"\tNév: {Name}" +
                $"\n\tOrszág: {Country}" +
                $"\n\tLakosság: {PopulationInThousands} ezer fő";
        }
    }
}
