namespace NovenyGyujtes_lib
{
    public class Mushroom : IPlant
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string Type { get; } = "Gomba";
        public int Value { get; init; }
        public char Representation { get; init; }
        public bool IsPoisionous { get; init; }

        public Mushroom(string name, string description, int value, char representation, bool isPoisionous)
        {
            Name = name;
            Description = description;
            Value = value;
            Representation = representation;
            IsPoisionous = isPoisionous;
        }

        public override string ToString()
        {
            return $"Gomba: {Name}, {Description}, {Type}, Mérgező: {IsPoisionous}" +
                $"Érték: {Value}, Megjelenítés {Representation}";
        }
    }
}
