namespace AutoApp
{
    internal class Auto
    {
        private readonly List<int> _sebessegek = new();

        public string Tipus { get; init; }
        public string Vezeto { get; set; }
        public int MaxSebesseg { get; init; }

        public double AtlagSebesseg => _sebessegek.Count == 0 ? 0 : _sebessegek.Average();

        public Auto()
        {
            Tipus = "Ismeretlen";
            Vezeto = "";
            MaxSebesseg = 100;
        }

        public Auto(string tipus, string vezeto, int maximalisSebesseg)
        {
            Tipus = tipus;
            Vezeto = vezeto;
            MaxSebesseg = maximalisSebesseg < 100 ? 100 : maximalisSebesseg;
        }

        public int SebessegMeres()
        {
            if (Vezeto == string.Empty) return 0;

            int sebesseg = Random.Shared.Next(MaxSebesseg / 4, MaxSebesseg);
            _sebessegek.Add(sebesseg);

            return sebesseg;
        }

        public string Log() => $"Az autó sofőrje: {Vezeto}, átlagsebessége: {AtlagSebesseg}";

        public int Osszehasonlitas(Auto auto)
        {
            if (auto.AtlagSebesseg < AtlagSebesseg) return 1;
            if (auto.AtlagSebesseg > AtlagSebesseg) return -1;
            return 0;
        }
    }
}
