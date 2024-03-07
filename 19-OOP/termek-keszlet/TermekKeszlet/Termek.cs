namespace TermekKeszlet
{
    internal class Termek
    {
        private double _kedvezmeny;

        public string Nev { get; init; }
        public int Ar { get; set; }

        public double Kedvezmeny
        {
            get => _kedvezmeny;
            set => _kedvezmeny = (value is > 0 and < 1) ? value : _kedvezmeny;
        }

        public uint RaktarKeszlet { get; set; }

        public Termek(string nev, int ar)
        {
            Nev = nev;
            Ar = ar;
            Kedvezmeny = 0;
            RaktarKeszlet = 1;
        }

        public Termek(string nev, int ar, uint raktarKeszlet)
        {
            Nev = nev;
            Ar = ar;
            Kedvezmeny = 0;
            RaktarKeszlet = raktarKeszlet;
        }

        public string Informacio() =>
            $"{Nev} ({Ar:C0}, kevezmény: {Kedvezmeny:P2}, kedvezményes ár: {Ar * Kedvezmeny:C0})" +
            $" - {RaktarKeszlet} db";

        public bool Eladas(uint db)
        {
            if (RaktarKeszlet >= db)
            {
                RaktarKeszlet -= db;
                return true;
            }

            return false;
        }

        public void Beszerzes(uint db) => RaktarKeszlet += db;
    }
}
