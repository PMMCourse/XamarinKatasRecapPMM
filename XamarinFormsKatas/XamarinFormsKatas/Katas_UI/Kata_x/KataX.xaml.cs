using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_x
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataX : ContentPage
	{
		public KataX ()
		{
			InitializeComponent ();
			var Lista = new List<string>();
			Lista.Add("Sevilla");
			Lista.Add("Cádiz");
			Lista.Add("Málaga");
			Lista.Add("Córdoba");
			Lista.Add("Jaen");
			Lista.Add("Granada");
			Lista.Add("Almería");
			pickerX.ItemsSource = Lista;
		}
		private void Tap(object sender, EventArgs e)
		{
			labelX.IsVisible = false;
			pickerX.IsVisible = true;
		}

		private void pickerX_SelectedIndexChanged(object sender, EventArgs e)
		{
			var pickerX = (Picker)sender;
			int item = pickerX.SelectedIndex;
			pickerX.IsVisible = false;
			labelX.Text = "Ha seleccionado " + pickerX.ItemsSource[item];
			labelX.IsVisible = true;
		}
	}
}