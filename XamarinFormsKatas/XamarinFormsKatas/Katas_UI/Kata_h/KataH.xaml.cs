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
        public async void animacion(object sender, EventsArgs e)
        {
            await btnAnimado.TranslateTo(0, -30, 195);
            await btnAnimado.RotateTo(359, 205);
            btnAnimado.TranslationY = 0;
            btnAnimado.Rotation = 0;
        }
	}
}