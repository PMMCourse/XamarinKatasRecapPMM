using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_g
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataG : ContentPage
	{
		public KataG ()
		{
			InitializeComponent ();
			BtnRotation.Clicked += async (sender, e) =>
			{
				await BtnRotation.RotateTo(360, 1500);
				BtnRotation.Rotation = 0;
			};
		}
	}
}