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
		public KataH()
		{
			InitializeComponent();

			RotateButtonAndMove.Clicked += async (sender, e) =>
			{

				await RotateButtonAndMove.TranslateTo(0, 100, 100);
				await RotateButtonAndMove.RotateTo(360, 500);
				await RotateButtonAndMove.TranslateTo(0, 0, 100);

				RotateButtonAndMove.Rotation = 0;

				RotateButtonAndMove.TranslationX = 0;
			};

		}
	}
}