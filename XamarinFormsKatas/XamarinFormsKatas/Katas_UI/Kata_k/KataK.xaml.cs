using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_k
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataK : ContentPage
	{
		List<string> lista = new List<string>();

		public KataK()
		{
			InitializeComponent();
			CargarLista();
			listaK.IsRefreshing = false;

			listaK.RefreshCommand = new Command(() =>
			{
				listaK.IsRefreshing = true;

				CargarLista();

				listaK.ItemsSource = null;
				listaK.ItemsSource = lista;
				listaK.IsRefreshing = false;
			});
		}

		private void crearLista()
		{
			lista.Add("DESLIZA");
			lista.Add("PARA");
			lista.Add("ABAJO");
			lista.Add("PARA");
			lista.Add("VER");
			lista.Add("MAGIA");
		}

		private void CargarLista()
		{
			crearLista();
			listaK.ItemsSource = lista;
		}
	}

}