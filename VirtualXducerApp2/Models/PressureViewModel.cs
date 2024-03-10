using System.ComponentModel;

namespace VirtualXducerApp2.Models
{
    public class PressureViewModel : INotifyPropertyChanged
    {
        string? _format = "N";
        public Pressure Pressure { get; }
        public string UnitName => Pressure.Unit.Name;
        public event PropertyChangedEventHandler? PropertyChanged;
        public string ValueStr
        {
            get
            {
                if (_format == null)
                    return "";
                return Pressure.Value.ToString(_format);
            }
        }

        public PressureViewModel(Pressure pressure)
        {
            Pressure = pressure;
        }

        public void SetFormat(string? format)
        {
            _format = format;
            OnPropertyChanged(nameof(ValueStr));
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
