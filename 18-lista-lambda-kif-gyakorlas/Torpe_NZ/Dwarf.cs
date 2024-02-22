namespace Torpe_NZ
{
    public enum Gender
    {
        Male,
        Female
    }

    public record Dwarf(string Name, string Clan, Gender Gender, int Weight, int Height)
    {
        public double BMI => Weight / Math.Pow(Height / 100.0, 2);

        public void PrintData()
        {
            Console.WriteLine($"\tNév: {Name}" +
                $"\n\tKlán: {Clan}" +
                $"\n\tNem: {(Gender == Gender.Male ? "férfi" : "nő")}" +
                $"\n\tSúly: {Weight} kg" +
                $"\n\tMagasság: {Height} kg");
        }
        
        public override string ToString()
        {
            return $"{Name} ({Clan})";
        }
    };
}
