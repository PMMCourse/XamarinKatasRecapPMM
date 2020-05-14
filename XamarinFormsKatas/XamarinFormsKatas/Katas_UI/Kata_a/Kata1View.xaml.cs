using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_b;
using XamarinFormsKatas.Katas_UI.Kata_c;
using XamarinFormsKatas.Katas_UI.Kata_d;
using XamarinFormsKatas.Katas_UI.Kata_e;

namespace XamarinFormsKatas.Katas.Kata1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata1View : ContentPage

	{
		public Kata1View ()
		{
			InitializeComponent ();
		}

		private async void BotonUIb_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new KataB());
		}

		private async void BotonUIc_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new KataC());
		}

		private async void BotonUId_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new KataD());
		}

		private async void BotonUIe_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new KataE());
		}
	}
}