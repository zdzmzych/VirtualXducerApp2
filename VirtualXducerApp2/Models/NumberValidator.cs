namespace VirtualXducerApp2.Models
{
    public class NumberValidator
    {
        public static bool IsValid(string? s, out double result)
        {
            if (s != null && double.TryParse(s.Replace(",", "."), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out result))
                return true;
            result = 0;
            return false;
        }
    }
}
