using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_n
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataN : TabbedPage
	{
		public KataN ()
		{
			InitializeComponent ();
		}

		private async void Btn_AbrirTab1(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Tab1());

		}

		private async void Btn_AbrirTab2(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Tab2());
		}

		private async void Btn_AbrirTab3(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Tab3());
		}
	}
}