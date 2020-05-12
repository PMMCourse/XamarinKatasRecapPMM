using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentView
    {
        public Page1(string text2)
        {
            InitializeComponent();
            string text1 = text2;
            BindingContext = new Page1ViewModel(text1);
        }
    }
}