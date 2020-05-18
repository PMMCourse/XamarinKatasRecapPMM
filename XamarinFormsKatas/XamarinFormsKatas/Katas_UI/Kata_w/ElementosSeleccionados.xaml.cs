using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementosSeleccionados : ContentPage
    {
        public ElementosSeleccionados(List<int> elementos)
        {
            InitializeComponent();
            foreach (int element in elementos)
            {
                switch (element) {
                    case 1:
                        elemento1.IsVisible = true;
                        break;
                    case 2:
                        elemento2.IsVisible = true;
                        break;
                    case 3:
                        elemento3.IsVisible = true;
                        break;
                    case 4:
                        elemento4.IsVisible = true;
                        break;
                }
            }

        }
    }
}