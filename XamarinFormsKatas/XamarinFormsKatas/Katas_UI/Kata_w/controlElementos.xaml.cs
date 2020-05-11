using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class controlElementos : ContentPage
    {
        public controlElementos(Entry EControl, Label LControl, Button BControl, ActivityIndicator AControl)
        {
            InitializeComponent();
            pagina.Children.Add(EControl);
            pagina.Children.Add(LControl);
            pagina.Children.Add(BControl);
            pagina.Children.Add(AControl);
        }
    }
}