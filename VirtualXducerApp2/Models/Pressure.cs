namespace VirtualXducerApp2.Models
{
    public class Pressure
    {
        public Pressure(double value, PressureUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        public double Value { get; protected set; }

        public double ValueInPa => Value * Unit.Pascals;

        public PressureUnit Unit { get; protected set; }

        public void SetUnit(PressureUnit unit)
        {
            Unit = unit;
        }

        public void SetValue(double value) 
        {
            Value = value;
        }

        public void ConvertFrom(Pressure other)
        {
            Value = other.ValueInPa / Unit.Pascals ;
        }

        public override string ToString()
        {
            return $"{Value} {Unit}";
        }
    }
}
