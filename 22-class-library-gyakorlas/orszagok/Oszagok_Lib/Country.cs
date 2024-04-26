namespace Oszagok_Lib
{
    public class Country
    {
        private uint _area;
        private uint _population;
        private uint _distanceFromBudapest;

        public string Name { get; set; }
        public string Capital { get; set; }

        public uint Area
        {
            get => _area;
            set => _area = value > 1 ? value : 1;
        }

        public uint Population
        {
            get => _population;
            set => _population = value > 20_000 ? value : 20_000;
        }

        public uint DistanceFromBudapest
        {
            get => _distanceFromBudapest;
            init
            {
                if (value < 200) _distanceFromBudapest = 200;
                else if (value > 25_000) _distanceFromBudapest = 25_000;
                else _distanceFromBudapest = value;
            }
        }

        public Country()
        {
            Name = "Ismeretlen";
            Area = 0;
            Population = 0;
            Capital = "Ismeretlen";
            DistanceFromBudapest = 0;
        }

        public Country(string name, uint area, uint population, string capital, uint distanceFromBudapest)
        {
            Name = name;
            Area = area;
            Population = population;
            Capital = capital;
            DistanceFromBudapest = distanceFromBudapest;
        }

        public string Info()
        {
            return $"\tOrszág neve: {Name}" +
                $"\n\tFővárosa: {Capital}" +
                $"\n\tTerülete: {Area} km2" +
                $"\n\tLakossága: {Population} fő" +
                $"\n\tTávolság Budapesttől: {DistanceFromBudapest} km";
        }

        public override string ToString()
        {
            return string.Join(';', Name, Area, Population, Capital, DistanceFromBudapest);
        }
    }
}
