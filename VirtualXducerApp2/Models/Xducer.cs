using System;

namespace VirtualXducerApp2.Models
{
    public class Xducer 
    {
        public double RangeStart { get; set; }
        public double RangeEnd { get; set; }
        public double SignalStart { get; set; }
        public double SignalEnd { get; set; }
        public double Signal { get; set; }
        public double Pressure { get; set; }
        public double Percent { get; set; }

        public double SignalSpan => SignalEnd - SignalStart;
        public double RangeSpan => RangeEnd - RangeStart;

        public double SensivityS => SignalSpan / RangeSpan;
        public double SensivityP => 1.0 / SensivityS;
        public bool Linear { get; set; }

        public Xducer()
        {
            RangeStart = 0;
            RangeEnd = 100;
            SignalStart = 4;
            SignalEnd = 20;
            Percent = 0;
            Pressure = RangeStart;
            Signal = SignalStart;
            Linear = true;
        }

        public void ChangeRangeStart(double start)
        {
            RangeStart = start;
            FromPercent(Percent);
        }

        public void ChangeRangeEnd(double end)
        {
            RangeEnd = end;
            FromPercent(Percent);
        }

        public void ChangeSignalStart(double start)
        {
            SignalStart = start;
            FromPercent(Percent);
        }

        public void ChangeSignalEnd(double end)
        {
            SignalEnd = end;
            FromPercent(Percent);
        }

        public void FromPercent(double value)
        {
            Percent = value;
            Pressure = PressureFromPercent(value);
            Signal = SignalFromPercent(value);
        }

        public void FromSignal(double value)
        {
            Signal = value;
            var s = (Signal - SignalStart) / SignalSpan;
            Percent = Linear ? 100.0 * s : 100.0*s*s;
            Pressure = PressureFromPercent(Percent);
        }

        public void FromPressure(double value)
        {
            Pressure = value;
            Percent = 100.0 * (Pressure - RangeStart) / RangeSpan;
            Signal = SignalFromPercent(Percent);
        }

        protected double PressureFromPercent(double value)
        {
            return RangeStart + value / 100.0 * (RangeEnd - RangeStart);
        }

        protected double SignalFromPercent(double value)
        {
            if(Linear) 
                return SignalStart + value / 100.0 * (SignalEnd - SignalStart);
            return SignalStart + Math.Sqrt(value / 100.0) * (SignalEnd - SignalStart);
        }
    }
}
