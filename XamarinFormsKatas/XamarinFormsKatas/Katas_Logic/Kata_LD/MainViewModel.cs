using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA.XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class MainViewModel : BaseViewModel
    {
        private Command _commandNavigation;
        public ICommand commandNavigation => _commandNavigation;
        public INavigation navigation { get; set; }


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
        public MainViewModel(INavigation navego)
        {
            navigation = navego;
            _commandNavigation = new Command(async () => await Navigation());
        }

        public async Task Navigation()
        {
            Page1 pag1 = new Page1(entrada);

        }
    }
}
