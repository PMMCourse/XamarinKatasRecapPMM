using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_c.view;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void BtnElemento1_Clicked(object sender, EventArgs e)
        {
            KataC.MenuOpciones.IsPresented = false;
            await KataC.MenuOpciones.Detail.Navigation.PushAsync(new elemento1View());
        }

        private async void BtnElemento2_Clicked(object sender, EventArgs e)
        {
            KataC.MenuOpciones.IsPresented = false;
            await KataC.MenuOpciones.Detail.Navigation.PushAsync(new elemento2View());
        }

        private async void BtnElemento3_Clicked(object sender, EventArgs e)
        {
            KataC.MenuOpciones.IsPresented = false;
            await KataC.MenuOpciones.Detail.Navigation.PushAsync(new elemento3View());
        }
    }
}