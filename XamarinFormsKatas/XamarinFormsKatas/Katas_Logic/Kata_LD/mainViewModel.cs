using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class mainViewModel:BaseViewModel
    {
        private Command _CmdNavegacion;
        public ICommand CmdNavegacion => _CmdNavegacion;
        public INavigation navegacion { get; set; }
        private string _entrada;
        public string entrada
        {
            get => _entrada;
            set
            {
                _entrada = value;
                OnPropertyChanged();
            }
        }
        public mainViewModel(INavigation navego)
        {
            navegacion = navego;
            _CmdNavegacion = new Command(async () => await navegacion());
        }
        public async Task Navegacion()
        {
            Pagina2 p2 = new Pagina2(entrada);
            await navegacion.PushAsync(p2);
        }
    }
}
