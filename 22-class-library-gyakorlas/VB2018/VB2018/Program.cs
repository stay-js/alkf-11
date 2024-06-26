﻿using VB_Lib;

#region 1.feladat
var stadiums = Stadiums.Parse(File.ReadAllLines("vb2018.txt"));
#endregion

#region 2.feladat
Console.WriteLine($"2. feladat: {stadiums.Count()} stadionban játszottak mérkőzést.");
#endregion

#region 3.feladat
Console.WriteLine("3. feladat: A legkevesebb férőhellyel rendelkező stadion: " +
    stadiums.MinBy(s => s.Capacity));
#endregion

#region 4.feladat
Console.WriteLine($"4. feladat: A stadionok átlagos férőhelye: {stadiums.AvgCapacity()} fő");
#endregion

#region 5.feladat
Console.WriteLine("5. feladat: Alternatív névvel rendelkező stadionok száma: " +
    stadiums.CountAlternativeName());
#endregion

#region 6.feladat
Console.WriteLine("6. feladat: Arénát tartalmazó stadionok száma: " +
    stadiums.CountWhereNameContains("Aréna"));
#endregion

#region 7.feladat
Console.WriteLine($"7. feladat: Városok: {string.Join(';', stadiums.Cities())}");
#endregion

#region 8.feladat
Console.Write("8. feladat: ");
stadiums.WriteToFile("stadionok.txt");
#endregion
