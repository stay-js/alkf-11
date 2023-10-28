Random random = new Random();

#region 1.feldat
int i = 0;
int currentThrow = 0;

Console.WriteLine("Dobások:");
while (currentThrow != 6)
{
    i++;
    currentThrow = random.Next(1, 7);
    
    Console.WriteLine(currentThrow);
}
Console.WriteLine($"{i}. dobásra sikerült 6-ost dobni.");
#endregion

#region 2.feladat
i = 0;
int currentThrow2;

Console.WriteLine("\nDobások:");
do
{
    i++;
    currentThrow = random.Next(1, 7);
    currentThrow2 = random.Next(1, 7);
    
    Console.WriteLine($"{currentThrow}; {currentThrow2}");
} while (currentThrow != currentThrow2);
Console.WriteLine($"{i}. dobásra sikerült ugyanolyan értékeket dobni.");
#endregion

#region 3.feladat
i = 0;
currentThrow = 0;
currentThrow2 = 0;
int currentThrow3 = 0;

Console.WriteLine("\nDobások:");
while (currentThrow != 6 && currentThrow2 != 6 && currentThrow3 != 6)
{
    i++;
    currentThrow = random.Next(1, 7);
    currentThrow2 = random.Next(1, 7);
    currentThrow3 = random.Next(1, 7);
    
    Console.WriteLine($"{currentThrow}; {currentThrow2}; {currentThrow3}");
}
Console.WriteLine($"{i}. dobásra sikerült legalább egy 6-ost dobni.");
#endregion

#region 4.feladat
i = 0;

Console.WriteLine("\nDobások:");
currentThrow = 0;

while (currentThrow < 5 || currentThrow2 < 5 || currentThrow3 < 5)
{
    i++;
    currentThrow = random.Next(1, 7);
    currentThrow2 = random.Next(1, 7);
    currentThrow3 = random.Next(1, 7);
    
    Console.WriteLine($"{currentThrow}; {currentThrow2}; {currentThrow3}");
}
Console.WriteLine($"{i}. dobásra lett mindegyik érték legalább 5.");
#endregion

#region 5.feladat
i = 0;

Console.WriteLine("\nDobások:");
do
{
    i++;
    currentThrow = random.Next(1, 7);
    currentThrow2 = random.Next(1, 7);
    currentThrow3 = random.Next(1, 7);
    
    Console.WriteLine($"{currentThrow}; {currentThrow2}; {currentThrow3}");
} while (currentThrow % 3 != 0 || currentThrow2 % 3 != 0 || currentThrow3 % 3 != 0);
Console.WriteLine($"{i}. dobásra lett mindegyik érték 3-mal osztható.");
#endregion

#region 6.feladat
i = 0;

Console.WriteLine("\nDobások:");
do
{
    i++;
    currentThrow = random.Next(1, 7);
    currentThrow2 = random.Next(1, 7);
    currentThrow3 = random.Next(1, 7);
    
    Console.WriteLine($"{currentThrow}; {currentThrow2}; {currentThrow3}");
} while (currentThrow != currentThrow2
         && currentThrow != currentThrow3
         && currentThrow2 != currentThrow3);
Console.WriteLine($"{i}. dobásra lett legalább 2 kockán ugyanaz az érték.");
#endregion

#region 6.feladat
i = 0;

Console.WriteLine("\nDobások:");
do
{
    i++;
    currentThrow = random.Next(1, 7);
    currentThrow2 = random.Next(1, 7);
    currentThrow3 = random.Next(1, 7);
    
    Console.WriteLine($"{currentThrow}; {currentThrow2}; {currentThrow3}");
} while (currentThrow == currentThrow2 
         || currentThrow == currentThrow3
         || currentThrow2 == currentThrow3);
Console.WriteLine($"{i}. dobásra lett mindhárom kockán különböző az érték.");
#endregion