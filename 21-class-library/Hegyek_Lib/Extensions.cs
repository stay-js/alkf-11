namespace Hegyek_Lib
{
    public static class Extensions
    {
        public static List<Mountain> ParseToMountainList(this string[] lines)
        {
            return lines.Skip(1).Select(line => new Mountain(line)).ToList();
        }

        public static double AvgHeight(this List<Mountain> mountains)
        {
            return Math.Round(mountains.Average(m => m.Height), 1);
        }

        public static int CountByMountainRange(this List<Mountain> mountains, string mountainRange)
        {
            return mountains.Count(m => m.MountainRange == mountainRange);
        }

        public static int CountWhereNameContains(this List<Mountain> mountains, string toContain)
        {
            return mountains.Count(m => m.Name.Contains(toContain));
        }

        public static string MountainRanges(this List<Mountain> mountains)
        {
            return string.Join(";", mountains.Select(m => m.MountainRange).Distinct().Order());
        }

        public static int CountTallerThanFeet(this List<Mountain> mountains, int heightInFeet)
        {
            double height = heightInFeet / 3.280839895;
            return mountains.Count(m => m.Height > height);
        }

        public static void WriteTallestToFile(this List<Mountain> mountains, int amount, string path)
        {
            File.WriteAllLines(path,
                mountains
                .OrderBy(m => m.Height)
                .Take(amount)
                .Select(m => $"{m.Height} m - {m.MountainRange}: {m.Name}")
                );
        }
    }
}
