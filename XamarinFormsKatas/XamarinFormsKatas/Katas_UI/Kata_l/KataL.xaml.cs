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
		public KataL()
		{
			InitializeComponent();
		}

		private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
		{
			lbSwipe.Text = "Swipe left";
		}

		private void SwipeGestureRecognizer_Swiped_1(object sender, SwipedEventArgs e)
		{
			lbSwipe.Text = "Swipe right";
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			lbSwipe.Text = "Tapped";

		}

		private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
		{
			lbSwipe.Text = "Pinch";
		}

	}
}
