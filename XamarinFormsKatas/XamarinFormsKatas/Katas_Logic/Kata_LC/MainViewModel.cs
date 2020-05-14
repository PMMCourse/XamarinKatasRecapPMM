using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
    public class MainViewModel : BaseViewModel
    {
        private Command _btnKataL;
        public ICommand btnKataL => _btnKataL;

        public MainViewModel()
        {
            _btnKataL = new Command(TextButton);
        }

        async void TextButton(object obj)
        {
            await Application.Current.MainPage.DisplayAlert("titulo del mensaje", "Cuerpo del mensaje", "Cancelar");
        }
    }
}
