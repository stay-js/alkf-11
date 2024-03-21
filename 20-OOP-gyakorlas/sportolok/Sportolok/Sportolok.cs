namespace Sportolok
{
    internal enum Kategoria
    {
        Amator,
        Profi,
        Klasszis
    }

    internal class Sportolo
    {
        public static int WR { get; private set; } = 0;

        private readonly int[] _eredmenyek = new int[20];
        private int _eszam = 0;

        public string Nev { get; init; }

        public int PB => _eredmenyek.Max();

        private static void SetWR(int record) => WR = record;

        public Sportolo(string nev) => Nev = nev;

        public Kategoria Kategoria
        {
            get
            {
                if (_eszam == 0) return Kategoria.Amator;
                if (PB < WR * 0.3) return Kategoria.Amator;
                if (PB < WR * 0.75) return Kategoria.Profi;
                return Kategoria.Klasszis;
            }
        }

        public void UjEredmeny(int eredmeny)
        {
            if (_eszam >= 20) return;

            _eredmenyek[_eszam++] = eredmeny;
            if (eredmeny > WR) SetWR(eredmeny);
        }

        public override string ToString()
        {
            return $"{Nev} - eredmények: " +
                (_eszam == 0 ? "-" : string.Join(", ", _eredmenyek[0.._eszam])) +
                $"; legjobb eredmény: {PB}; kategória: {Kategoria}";
        }
    }
}
