namespace NovenyGyujtes_lib
{
    public interface IPlant
    {
        string Name { get; }
        string Description { get; }
        string Type { get; }
        int Value { get; }
        char Representation { get; }
    }
}