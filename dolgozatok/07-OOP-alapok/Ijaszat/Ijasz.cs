namespace Ijaszat
{
    internal class Ijasz
    {
        private const int _TP = 10;
        private int _alloKepesseg;
        private int _ugyesseg;
        private int _tapasztalat = 0;

        public static bool AkaratEro => Random.Shared.Next(1, 11) == 1;

        public int Szint { get; private set; } = 1;

        public int AlloKepesseg
        {
            get => _alloKepesseg;
            set
            {
                if (value < 0) _alloKepesseg = 0;
                else if (value > 100) _alloKepesseg = 100;
                else _alloKepesseg = value;
            }
        }

        public int Ugyesseg
        {
            get => _ugyesseg;
            set
            {
                if (value < 0) _ugyesseg = 0;
                else if (value > 10) _ugyesseg = 10;
                else _ugyesseg = value;
            }
        }

        public Ijasz()
        {
            AlloKepesseg = Random.Shared.Next(30, 61);
            Ugyesseg = 1;
        }

        public Ijasz(int ugyesseg)
        {
            AlloKepesseg = Random.Shared.Next(50, 76);
            Ugyesseg = ugyesseg;
        }

        public bool Lo()
        {
            if (AlloKepesseg < 5 && !AkaratEro) return false;

            AlloKepesseg -= 5;
            _tapasztalat += Szint * Ugyesseg;

            if (_tapasztalat > _TP * Szint * Szint)
            {
                Szint++;
                _tapasztalat = 0;

                if (Szint % 3 == 0) Ugyesseg++;
            }

            return true;
        }

        public void Pihen() => AlloKepesseg += Random.Shared.Next(1, 11);

        public string Info() => $"{Szint}. szintű íjász. Ügyessége: {Ugyesseg} Állóképessége: {AlloKepesseg}";
        public override string ToString() => Info();
    }
}
