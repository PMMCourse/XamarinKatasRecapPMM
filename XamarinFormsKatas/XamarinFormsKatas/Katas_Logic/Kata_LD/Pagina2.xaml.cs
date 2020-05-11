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
    public partial class Pagina2 : ContentPage
    {
        public Pagina2(string texto)
        {
            InitializeComponent();
            string t = texto;
            BindingContext = new pagina2_VM(t);
        }
    }
}