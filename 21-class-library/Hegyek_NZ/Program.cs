using Hegyek_Lib;

#region 1.feladat
var mountains = File.ReadAllLines("hegyekMo.txt").ParseToMountains();
#endregion

#region 2.feladat
Console.WriteLine($"2. feladat: Tárolt hegycsúcsok száma: {mountains.Count()}");
#endregion

#region 3.feladat
Console.WriteLine($"3. feladat: Legalacsonyabb hegycsúcs: {mountains.MinBy(m => m.Height)}");
#endregion

#region 4.feladat
Console.WriteLine($"4. feladat: Hegycsúcsok átlagos magassága: {mountains.AvgHeight()} m");
#endregion

#region 5.feladat
Console.WriteLine("5. feladat: A Mátrában található hegycsúcsok száma: " +
    mountains.CountByMountainRange("Mátra"));
#endregion

#region 6.feladat
Console.WriteLine("6. feladat: \"bérc\"-et tartalmazó hegycsúcsok száma: " +
    mountains.CountWhereNameContains("bérc"));
#endregion

#region 7.feladat
Console.WriteLine($"7. feladat: Hegységek: {string.Join(';', mountains.MountainRanges())}");
#endregion

#region 8.feladat
Console.WriteLine("8. feladat: 3000 lábnál magasabb hegycsúcsok: " +
    mountains.CountTallerThanFeet(3000));
#endregion

#region 9.feladat
mountains.WriteTallestToFile(3, "haromlegmag.txt");
#endregion
