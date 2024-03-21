namespace RepApp
{
    internal class Repa
    {
        private readonly int _tapErtek = Random.Shared.Next(1, 6);
        private double _minoseg = 0.99;

        public int Kor { get; private set; } = 0;
        public double TapErtek => _tapErtek * _minoseg;

        public double Minoseg
        {
            get => _minoseg;
            set => _minoseg = 0 < value && value < 1 ? value : _minoseg;
        }

        public string Fajta { get; init; }

        public Repa() => Fajta = new string[] { "sárgarépa", "fehérrépa", "cukorrépa" }[Random.Shared.Next(0, 2)];

        public Repa(string fajta) => Fajta = fajta;

        public override string ToString() => $"{Fajta} ({Kor} éves) - {TapErtek}";

        public bool Tick(int korNoveles, double minosegCsokkentes)
        {
            Kor += korNoveles;
            _minoseg -= minosegCsokkentes;

            return Kor < 30 && _minoseg > 0;
        }
    }
}
