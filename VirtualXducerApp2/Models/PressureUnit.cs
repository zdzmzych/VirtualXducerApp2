namespace VirtualXducerApp2.Models
{
    public class PressureUnit
    {
        public PressureUnit(string name, double pascals)
        {
            Name = name;
            Pascals = pascals;
        }
        public string Name { get; private set; }

        public double Pascals { get; private set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && !string.IsNullOrWhiteSpace(Name) && obj is PressureUnit unit ? Name.Equals(unit.Name) : false;
        }
        public static PressureUnit kPa => new PressureUnit("kPa", 1000);
    }
}
