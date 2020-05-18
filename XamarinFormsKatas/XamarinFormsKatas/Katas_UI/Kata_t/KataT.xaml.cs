using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_t.model;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataT : ContentPage
	{
		public List<deportista> listaDeportistas { get; private set; }

		public KataT ()
		{
			InitializeComponent ();
			listaDeportistas = new List<deportista>();
			listaDeportistas.Add(new deportista { Puntuacion = 8.5, Nombre = "Fran", Edad = 19, Deporte = "Fútbol" });
			listaDeportistas.Add(new deportista { Puntuacion = 7.8, Nombre = "Chema", Edad = 45, Deporte = "Pádel" });
			listaDeportistas.Add(new deportista { Puntuacion = 5, Nombre = "Otro", Edad = 28, Deporte = "Petanca" });
			BindingContext = this;
		}
	}
}