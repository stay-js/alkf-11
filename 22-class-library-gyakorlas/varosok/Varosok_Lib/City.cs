namespace Varosok_Lib
{
    public class City
    {
        public string Name { get; init; }
        public string County { get; init; }
        public uint Population { get; init; }
        public double Area { get; init; }
        public uint? YearOfDeclaration { get; init; }

        public double PopulationDensity => Population / Area;
        public string? YearOfDeclarationAsString => YearOfDeclaration is null ? "Ősi város" : YearOfDeclaration.ToString();

        public City(string input)
        {
            string[] parts = input.Split(';');

            Name = parts[0];
            County = parts[1];
            Population = uint.Parse(parts[2]);
            Area = double.Parse(parts[3]);
            YearOfDeclaration = parts[4] == "1885 előtt" ? null : uint.Parse(parts[4]);
        }

        public string Info()
        {
            return $"\tNépsűrűség: {PopulationDensity:N2} fő/km2" +
                $"\n\tVármegye: {County}" +
                $"\n\tVárossá nyilvánítás éve: {YearOfDeclarationAsString}";
        }

        public override string ToString()
        {
            return $"\tNév: {Name}" +
                $"\n\tVármegye: {County}" +
                $"\n\tLakossága: {Population} fő" +
                $"\n\tVárossá nyilvánítás éve: {YearOfDeclarationAsString}";
        }
    }
}
