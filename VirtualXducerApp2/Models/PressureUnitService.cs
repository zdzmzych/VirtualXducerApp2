namespace VirtualXducerApp2.Models
{
    public class PressureUnitService
    {
        public static IEnumerable<PressureUnit> Units => new List<PressureUnit>()
        {
            new PressureUnit("atm",1.013250E+05),
            new PressureUnit("bar",1.00000E+05),
            new PressureUnit("mbar",1.00000E+02),
            new PressureUnit("Pa",1.00000E+00),
            new PressureUnit("hPa",1.00000E+02),
            new PressureUnit("kPa",1.00000E+03),
            new PressureUnit("MPa",1.00000E+06),
            new PressureUnit("osi", 4.309223E+02),
            new PressureUnit("psf", 4.788025E+01),
            new PressureUnit("psi", 6.894757E+03),
            new PressureUnit("tsf", 9.576052E+04),
            new PressureUnit("tsi", 1.378951E+07),
            new PressureUnit("mTorr",1.333220E-01),
            new PressureUnit("Torr",1.333220E+02),
            new PressureUnit("inHg 0°C",3.386390E+03),
            new PressureUnit("inHg 60°F",3.376850E+03),
            new PressureUnit("inH2O 4°C",2.490820E+02),
            new PressureUnit("inH2O 20°C",2.486410E+02),
            new PressureUnit("inH2O 60°F",2.488400E+02),
            new PressureUnit("ftH2O 4°C",2.988980E+03),
            new PressureUnit("ftH2O 20°C",2.983692E+03),
            new PressureUnit("ftH2O 60°F",2.986080E+03),
            new PressureUnit("inSW 0°C 3.5% salinity",2.560885E+02),
            new PressureUnit("ftSW 0°C 3.5% salinity",3.073062E+03),
            new PressureUnit("mmH2O 4°C",9.806378E+00),
            new PressureUnit("cmH2O 4°C",9.806378E+01),
            new PressureUnit("mH2O 4°C",9.806378E+03),
            new PressureUnit("mmH2O 20°C",9.789017E+00),
            new PressureUnit("cmH2O 20°C",9.789017E+01),
            new PressureUnit("mH2O 20°C",9.789017E+03),
            new PressureUnit("mmHg 0°C",1.333220E+02),
            new PressureUnit("cmHg 0°C",1.333220E+03),
            new PressureUnit("dyn/cm²",1.00000E-01),
            new PressureUnit("g/cm²",9.806647E+01),
            new PressureUnit("kg/cm²",9.806647E+04),
            new PressureUnit("mSW 0°C 3.5% salinity", 1.008222E+04),
            new PressureUnit("µHg 0°C",1.333220E-01),
            new PressureUnit("mHg 0°C", 1.333220E+05),
        };
    }
}
