namespace NovenyGyujtes_lib
{
    public class Herb : IPlant
    {
        private readonly string _effect;

        public string Name { get; init; }
        public string Description { get; init; }
        public string Type { get; } = "Gyógynövény";
        public int Value { get; init; }
        public char Representation { get; init; }

        public string Effect => _effect;

        public Herb(string name, string description, int value, char representation, string effect)
        {
            Name = name;
            Description = description;
            Value = value;
            Representation = representation;
            _effect = effect;
        }

        public override string ToString()
        {
            return $"Gyógynövény: {Name}, {Description}, {Type}, Hatás: {Effect} " +
                $"Érték: {Value}, Megjelenítés: {Representation}";
        }
    }
}
