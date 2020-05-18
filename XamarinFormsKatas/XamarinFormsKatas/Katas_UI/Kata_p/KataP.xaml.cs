using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataP : ContentPage
	{
		public KataP ()
		{
			InitializeComponent ();
		}

		private async void BtnIndicadorClicked(object sender, EventArgs e)
		{
			Btn_Indicador.IsEnabled = false;
			Indicador.IsRunning = true;
			Indicador.IsEnabled = true;
			Indicador.IsVisible = true;
			await Task.Delay(5000);
			Indicador.IsRunning = false;
			Indicador.IsEnabled = false;
			Indicador.IsVisible = false;
			Btn_Indicador.IsEnabled = true;
		}


		protected override bool OnBackButtonPressed()
		{
			Device.BeginInvokeOnMainThread(async () => {
				var result = Indicador.IsRunning;
				if (result == false) await this.Navigation.PopAsync();
			});

			return true;

		}
	}
}