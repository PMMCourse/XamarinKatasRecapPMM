using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LG
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementControl : ContentPage
    {
        public ElementControl()
        {
            InitializeComponent();
            BindingContext = new ControlViewModel();
        }
    }
}