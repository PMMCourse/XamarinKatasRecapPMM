using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class pagina2_VM:BaseViewModel
    {
        private string _texto;
        public string texto
        {
            get => _texto;
            set
            {
                _texto = value;
                OnPropertyChanged();
            }
        }
        public pagina2_VM(string Texto)
        {
            texto = Texto;
        }
    }
}
