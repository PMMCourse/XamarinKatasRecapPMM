using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
    public class KataLfViewModel : BaseViewModel
    {
        private ObservableCollection<Deportistas> _deportistas = new ObservableCollection<Deportistas>();
        public ObservableCollection<Deportistas> deportistas
        {
            get => _deportistas;
            set
            {
                _deportistas = value;
                OnPropertyChanged();
            }
        }

        public KataLfViewModel()
        {
            _deportistas.Add(new Deportistas() { Deporte = "Futbol", Edad = 22, Puntuacion = 80, Sexo = "Hombre" });
            _deportistas.Add(new Deportistas() { Deporte = "Futbol", Edad = 23, Puntuacion = 100, Sexo = "Mujer" });
            _deportistas.Add(new Deportistas() { Deporte = "Futbol", Edad = 22, Puntuacion = 40, Sexo = "Hombre" });
            _deportistas.Add(new Deportistas() { Deporte = "Baloncesto", Edad = 29, Puntuacion = 60, Sexo = "Mujer" });

            _deportistas = new ObservableCollection<Deportistas>(_deportistas.Where(x => x.Deporte.Contains("F") && x.Puntuacion > 50));
        }
    }
}
