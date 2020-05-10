using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_o
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataO : ContentPage
	{
		public KataO ()
		{
			InitializeComponent ();
            this.Disappearing += desaparecer;
		}
        private void desaparecer(object sender, EventArgs e)
        {
            var decision = await DisplayAlert("¿Estas seguro de querer salir?", "¿deseas salir de esta app?", "si", "no");
            if (decision == true)
            {
                Process.GetCurrentProcess().CloseMainWindow();
            }
        }
	}
}