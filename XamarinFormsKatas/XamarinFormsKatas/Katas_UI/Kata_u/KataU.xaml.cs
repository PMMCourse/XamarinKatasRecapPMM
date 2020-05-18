using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_u.model;

namespace XamarinFormsKatas.Katas_UI.Kata_u
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataU : ContentPage
	{
		private ObservableCollection<deportistau> _listaDeportistasu;
		public ObservableCollection<deportistau> listaDeportistasu
		{
			get { return _listaDeportistasu; }
			set
			{
				_listaDeportistasu = value;
				OnPropertyChanged("listaDeportistasu");
			}
		}

		public KataU ()
		{
			InitializeComponent ();
			listaDeportistasu = new ObservableCollection<deportistau>();

			listaDeportistasu.Add(new deportistau { Puntuacion = 8.5, Nombre = "Fran", Edad = 19, Deporte = "Fútbol" });
			listaDeportistasu.Add(new deportistau { Puntuacion = 7.8, Nombre = "Chema", Edad = 45, Deporte = "Pádel" });
			listaDeportistasu.Add(new deportistau { Puntuacion = 5, Nombre = "Otro", Edad = 28, Deporte = "Petanca" });
			BindingContext = this;
		}

		private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
		{
			listviewU.BeginRefresh();
			if (string.IsNullOrWhiteSpace(e.NewTextValue))
				listviewU.ItemsSource = listaDeportistasu;
			else
				listviewU.ItemsSource = listaDeportistasu.Where(i => i.Nombre.ToLower().Contains(e.NewTextValue.ToLower()) || i.Deporte.ToLower().Contains(e.NewTextValue.ToLower()) || i.Edad.ToString().Contains(e.NewTextValue) || i.Puntuacion.ToString().Contains(e.NewTextValue));
			listviewU.EndRefresh();
		}
	}

}