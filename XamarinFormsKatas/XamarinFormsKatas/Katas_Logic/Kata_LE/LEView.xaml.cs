using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LEView : ContentPage
    {
        public LEView()
        {
            InitializeComponent();
            BindingContext = new LEViewModel();
        }

        private void ColorTextChanged(object sender, TextChangedEventArgs e)
        {
            (BindingContext as LEViewModel).BlendColorsCommand.Execute(null);
        }
    }
}