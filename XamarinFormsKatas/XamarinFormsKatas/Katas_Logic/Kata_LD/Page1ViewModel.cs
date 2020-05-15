using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class Page1ViewModel : BaseViewModel
    {
        private string _txt;

        public string txt
        {
            get => _txt;
            set
            {
                _txt = value;
                OnPropertyChanged();
            }
        }

        public Page1ViewModel(string textoo)
        {
            this.txt = textoo;
        }
    }
}
