using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MVVMEmilioGuerrero.ViewModels
{
    public class CambioDivisasViewModel : INotifyPropertyChanged
    {
        private string _valorDolares;
        private string _valorEuros;

        public string ValorDolares
        {
            get => _valorDolares;
            set 
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
        
        public string ValorEuros
        {
            get => _valorEuros;
            set
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
            double conversion = double.Parse(_valorDolares) * 0.95;
        }

        public void ConvertirEurosDolares()
        {
            double conversion = double.Parse(_valorDolares) * 1.05;

        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
