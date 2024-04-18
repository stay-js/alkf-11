namespace VB_Lib
{
    public class Stadium
    {
        public string City { get; init; }
        public string Name { get; init; }
        public string? Name2 { get; init; }
        public int Capacity { get; init; }

        public Stadium(string input)
        {
            string[] parts = input.Split(';');

            City = parts[0];
            Name = parts[1];
            Name2 = parts[2] == "n.a." ? null : parts[2];
            Capacity = int.Parse(parts[3]);
        }

        public override string ToString() => $"{Name} ({Name2}) - {City}, {Capacity} fő";
    }
}
