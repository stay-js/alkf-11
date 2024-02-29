namespace TeglalApp
{
    internal class Teglalap
    {
        private double _a;
        private double _b;

        public double A
        {
            get => _a;
            set => _a = value > 0 ? value : _a;
        }

        public double B
        {
            get => _b;
            set => _b = value > 0 ? value : _b;
        }

        public Teglalap()
        {
            _a = 1;
            _b = 2;
        }

        public Teglalap(double a, double b)
        {
            _a = a > 0 ? a : 1;
            _b = b > 0 ? b : 2;
        }

        public double Kerulet() => 2 * (A + B);
        public double Terulet() => A * B;

        public override string ToString()
        {
            return $"a: {A}, b: {B}, kerület: {Kerulet()}, terület: {Terulet()}";
        }
    }
}
