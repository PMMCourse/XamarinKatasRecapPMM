using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;  
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
            Binding();
        }

        void Binding()
        {
            btnV1.Clicked += async (sener, e) => await App.MasterDetail.Detail.Navigation.PushAsync(new Vista1());
            btnV2.Clicked += async (sener, e) => await App.MasterDetail.Detail.Navigation.PushAsync(new Vista2());
            btnV3.Clicked += async (sener, e) => await App.MasterDetail.Detail.Navigation.PushAsync(new Vista3());
        }
    }
}