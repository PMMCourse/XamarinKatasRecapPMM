using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata_LI : ContentPage
	{
		public Kata_LI ()
		{
			InitializeComponent ();
           
		}
        private void RealizarLLamada(object sender, EventArgs e)
        {
            DependencyService.Get<ITelefono>().RealizarLLamada(numeroTelefono.Text.ToString());
        }

    }
}