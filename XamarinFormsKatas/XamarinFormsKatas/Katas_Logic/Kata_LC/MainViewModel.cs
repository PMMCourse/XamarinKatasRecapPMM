using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
    public class MainViewModel: baseViewModel
    {
        private Command _command;
        public ICommand command => _command;

        public MainViewModel()
        {
            _command = new Command(checkButton);
        }
        async void checkButton()
        {
            await Application.Current.MainPage.DisplayAlert("titulo", "message", "Cancelar");

        }
    }
}
