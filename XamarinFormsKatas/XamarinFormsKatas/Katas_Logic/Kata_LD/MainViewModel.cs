using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class MainViewModel : BaseViewModel
    {
        private Command _navegationCommand;
        public ICommand navigationCommand => _navegationCommand;

        public INavigation navegar { get; set; }

        private string _entryText;
        public string entryText
        {
            get => _entryText;
            set
            {
                _entryText = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(INavigation navegate)
        {
            navegar = navegate;
            _navegationCommand = new Command(async () => await Navigation());
        }

        public MainViewModel()
        {
        }

        public async Task Navigation()
        {
            Page1 p1 = new Page1(entryText);
            await navegar.PushAsync(p1);
        }
    }
}
