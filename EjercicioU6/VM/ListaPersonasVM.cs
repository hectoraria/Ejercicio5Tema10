using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioU6.VM
{
    public class ListaPersonasVM : INotifyPropertyChanged
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
