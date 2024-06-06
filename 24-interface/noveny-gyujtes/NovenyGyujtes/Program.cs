using NovenyGyujtes_lib;

const int SIZE = 20;

var byName = new Dictionary<string, int>();
var byType = new Dictionary<string, int>();
int sum = 0;

for (int i = 0; i < SIZE; i++)
{
    for (int j = 0; j < SIZE; j++)
    {
        var noveny = PlantFactory.Create();
        Console.Write(noveny.Representation);

        sum += noveny.Value;

        if (byName.ContainsKey(noveny.Name)) byName[noveny.Name]++;
        else byName[noveny.Name] = 1;

        if (byType.ContainsKey(noveny.Type)) byType[noveny.Type]++;
        else byType[noveny.Type] = 1;
    }

    Console.WriteLine();
}

Console.WriteLine($"\nÖsszérték: {sum}");

Console.WriteLine("\nNév szerint:");
foreach (var item in byName)
{
    Console.WriteLine($"\t{item.Key}: {item.Value}");
}

Console.WriteLine("\nTípus szerint:");
foreach (var item in byType)
{
    Console.WriteLine($"\t{item.Key}: {item.Value}");
}
