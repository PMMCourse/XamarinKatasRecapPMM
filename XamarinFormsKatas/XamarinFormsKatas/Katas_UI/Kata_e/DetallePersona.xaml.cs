using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePersona : ContentPage
    {
        public DetallePersona(string Nombre, int Edad, string UrlFoto)
        {
            InitializeComponent();
            NombrePersona.Text = Nombre;
            EdadPersona.Text = "Edad: " + Edad.ToString();
            FotoPersona.Source = new UriImageSource()
            {
                Uri = new Uri(UrlFoto)
            };
        }
    }
}