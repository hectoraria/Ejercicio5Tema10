using ENT;
using DAL;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio5Tema10.VM
{
    internal class ListaPersonasVM : INotifyPropertyChanged
    {
        #region Atributos
        private ClsPersona personaSeleccionada;
        #endregion

        public ClsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                if (personaSeleccionada != value)
                {
                    personaSeleccionada = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<ClsPersona> ListaPersonas { get; set; }

        public ListaPersonasVM()
        {
            ListaPersonas = new ObservableCollection<ClsPersona>(ClsListadoDAL.listadoPersonas());
        }

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
