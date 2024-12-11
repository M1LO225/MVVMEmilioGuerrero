using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MVVMEmilioGuerrero.ViewModels
{
    public class CambioDivisasViewModel : INotifyPropertyChanged
    {
        private double _valorDolares;
        private double _valorEuros;

        public double ValorDolares
        {
            get => _valorDolares;
            private set
            {
                if (_valorDolares != value)
                {
                    _valorDolares = value;
                    OnPropertyChanged();
                    ConvertirDolaresEuros();
                    //generar eventos para cambiar de dolares a euros
                }
            }
        }
        
        public double ValorEuros
        {
            get => _valorEuros;
            private set
            {
                if ( _valorEuros != value)
                {
                    _valorEuros = value;
                    OnPropertyChanged();
                    ConvertirEurosDolares();
                    //generar eventos para cambiar de euros a dolares
                }
            }
        }

        public void ConvertirDolaresEuros()
        {
            ValorEuros = ValorDolares * 0.95;
        }

        public void ConvertirEurosDolares()
        {
            ValorDolares = ValorEuros * 1.05;

        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
