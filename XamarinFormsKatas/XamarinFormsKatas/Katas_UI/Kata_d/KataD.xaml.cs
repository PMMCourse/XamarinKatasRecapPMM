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
		public KataD ()
		{
			InitializeComponent ();

		}
        public void insertar()
        {
            List<Persona> Personas = new List<Persona>();
            Persona p = new Persona("Juan", 25);
            Persona p1 = new Persona("Marina", 18);
            Personas.Add(p);
            Personas.Add(p1);
            ListaPersonas.ItemsSource = Personas;
        }
	}
}