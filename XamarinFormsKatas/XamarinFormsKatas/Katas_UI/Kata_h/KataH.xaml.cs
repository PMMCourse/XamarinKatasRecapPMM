using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_h
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataH : ContentPage
	{
		public KataH ()
		{
			InitializeComponent ();
		}

		private async void BtnAnimarH(object sender, EventArgs args)
		{
			await botonEjerH.TranslateTo(0, -150, 1000);
			await botonEjerH.RelRotateTo(360, 1000);
		}
	}
}