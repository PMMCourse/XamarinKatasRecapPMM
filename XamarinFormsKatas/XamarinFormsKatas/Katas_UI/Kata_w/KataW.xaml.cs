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
	public partial class KataW : ContentPage
	{
		public KataW ()
		{
			InitializeComponent ();
		}

		private void swToggled(object sender, ToggledEventArgs e)
		{
			elemento1.IsEnabled = sw1.IsToggled;
			if(sw2.IsToggled)
			{
				elemento2.FontAttributes = FontAttributes.Bold;
			} else
			{
				elemento2.FontAttributes = FontAttributes.None;
			}
			elemento3.IsEnabled = sw3.IsToggled;
			elemento4.IsRunning = sw4.IsToggled;
		}

		private async void btnW_Clicked(object sender, EventArgs e)
		{
			List<int> elementos = new List<int>();
			if (sw1.IsToggled)
			{
				elementos.Add(1);
			}

			if (sw2.IsToggled)
			{
				elementos.Add(2);
			}

			if (sw3.IsToggled)
			{
				elementos.Add(3);
			}
			if (sw4.IsToggled)
			{
				elementos.Add(4);
			}

			await Navigation.PushAsync(new ElementosSeleccionados(elementos));

		}
	}
}