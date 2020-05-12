using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_j.ViewModel
{
    public class LoginViewModel:BindableObject
    {
        private string _eUsuario;
        public string EUsuario
        {
            get => _eUsuario;
            set
            {
                _eUsuario = value;
                OnPropertyChanged();
            }
        }
        private string _eApellidos;
        public string EApellidos
        {
            get => _eApellidos;
            set
            {
                _eApellidos = value;
                OnPropertyChanged();
            }
        }
        bool CanLoginExecute()
        {
            if (!string.IsNullOrEmpty(_eUsuario) && string.IsNullOrEmpty(_eApellidos))
            {
                return;
            }
        }
        public ICommand LoginCommand
        {
            get
            {
                if (CanLoginExecute())
                {
                    DisplayAlert("Login", "se logueo", "ok");
                    LError.IsVisible = false;
                }
                else
                {
                    LError.IsVisible = true;
                }
            
            }
        }
        public LoginViewModel()
        {

        }
    }
}
