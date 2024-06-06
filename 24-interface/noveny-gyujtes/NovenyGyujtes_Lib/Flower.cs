namespace NovenyGyujtes_lib
{
    public class Flower : IPlant
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string Type { get; } = "Virág";
        public int Value { get; init; }
        public char Representation { get; init; }

        public Flower(string name, string description, int value, char representation)
        {
            Name = name;
            Description = description;
            Value = value;
            Representation = representation;
        }

        public override string ToString()
        {
            return $"Virág: {Name}, {Description}, {Type}, " +
                $"Érték: {Value}, Megjelenítés: {Representation}";
        }
    }
}
