using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
    public class MainViewModel : BindableObject
    {
        public MainViewModel()
        {

        }
        private Athlete _athlete = new Athlete(21, 25, "Fekir", "Fútbol");
        public Athlete athlete

        {
            get => _athlete;
            set
            {
                _athlete = value;
                OnPropertyChanged();
            }
        }
    }
}
