namespace Hegyek_Lib
{
    public class Mountain
    {
        public string Name { get; init; }
        public string MountainRange { get; init; }
        public int Height { get; init; }

        public Mountain(string input)
        {
            string[] parts = input.Split(';');

            Name = parts[0];
            MountainRange = parts[1];
            Height = int.Parse(parts[2]);
        }

        public override string ToString() => $"{Name} ({MountainRange}), {Height} m";
    }
}
