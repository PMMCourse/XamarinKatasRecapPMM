using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataF : ContentPage
	{
		List<string> person = new List<string> { "chema", "juanca", "joselu", "juanki", "cueto" };

		public KataF ()
		{
			InitializeComponent ();
			listaNombre.ItemsSource = person;
		}

		private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
		{
			var letras = MainSearchBar.Text;
			listaNombre.ItemsSource = person.Where(person => person.ToLower().Contains(letras));
		}
	}
}