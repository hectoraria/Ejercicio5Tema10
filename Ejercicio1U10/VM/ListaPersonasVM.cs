using DAL;
using EjercicioU10.VM.Utils;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1U10.VM
{
    public class ListaPersonasVM
    {
        #region Atributos
        private ClsPersona personaSeleccionada;
        private DelegateCommand eliminar;
        #endregion

        public ClsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                if (personaSeleccionada != value)
                {
                    personaSeleccionada = value;
                    NotifyPropertyChanged("PersonaSeleccionada");
                    eliminar.RaiseCanExecuteChanged();
                }
            }
        }
        public DelegateCommand Eliminar
        {
            get { return eliminar; }
        }

        public ObservableCollection<ClsPersona> ListaPersonas { get; set; }

        public ListaPersonasVM()
        {
            ListaPersonas = new ObservableCollection<ClsPersona>(ClsListadoDAL.listadoPersonas());
            eliminar = new DelegateCommand(Execute, CanExecute);
        }

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region eventos
        public event EventHandler? CanExecuteChanged;
        private bool CanExecute()
        {
            bool sePuede = true;
            if (personaSeleccionada == null)
            {
                sePuede = false;
            }
            return sePuede;
        }

        public void Execute()
        {
            ListaPersonas.Remove(PersonaSeleccionada);
        }
        #endregion
    }
}
