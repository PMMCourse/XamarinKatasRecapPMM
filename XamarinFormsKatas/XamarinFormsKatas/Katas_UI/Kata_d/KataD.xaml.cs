using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
        List<Persona> Personas = new List<Persona>();

        public KataD ()
		{
			InitializeComponent ();
            insertar();

            Seleccion();

		}
        public void insertar()
        {
            Persona p = new Persona("Juan", 25, "imagenp.png");
            Persona p1 = new Persona("Marina", 18, "imagen2.png");
            Personas.Add(p);
            Personas.Add(p1);
            ListaPersonas.ItemsSource = Personas;
        }
        public void Seleccion()
        {
            Personas.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem!= null)
                {
                    Navigation.PushAsync(new Katas_UI.Kata_e.KataE(e.SelectedItem as Persona));
                    ((ListView)sender).SelectedItem = null;
                }
            };
        }
	}
}