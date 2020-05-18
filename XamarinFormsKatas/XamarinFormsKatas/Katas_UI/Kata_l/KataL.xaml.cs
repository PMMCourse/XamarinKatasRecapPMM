using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_l
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataL : ContentPage
	{
		public KataL ()
		{
			InitializeComponent ();
		}

		private async void SwipeIzq(object sender, SwipedEventArgs e)
		{
			LabelEjerL.Text = "Se ha hecho un Swipe a la Izquierda";
			await Task.Delay(3000);
			LabelEjerL.Text = "Haz algo";
		}

		private async void SwipeDer(object sender, SwipedEventArgs e)
		{
			LabelEjerL.Text = "Se ha hecho un Swipe a la Derecha";
			await Task.Delay(1000);
			LabelEjerL.Text = "Haz algo";
		}

		private async void Tap(object sender, EventArgs e)
		{
			LabelEjerL.Text = "Se ha pulsado";
			await Task.Delay(1000);
			LabelEjerL.Text = "Haz algo";
		}

		private async void Pinch(object sender, PinchGestureUpdatedEventArgs e)
		{
			LabelEjerL.Text = "Se ha hecho Pinch";
			await Task.Delay(1000);
			LabelEjerL.Text = "Haz algo";
		}
	}
}