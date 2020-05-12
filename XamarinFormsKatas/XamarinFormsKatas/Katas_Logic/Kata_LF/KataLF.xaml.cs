using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLF : ContentPage
	{
        List<Deportista> lista = new List<Deportista>();
		public KataLF ()
		{
			InitializeComponent ();


            Deportista dpt1 = new Deportista(28, "Juan", "tenis", 28);
            Deportista dpt2 = new Deportista(52, "Martin", "baloncesto", 20);
            Deportista dpt3 = new Deportista(30, "Pau", "futbol", 34);
            lista.Add(dpt1.ToString());
            lista.Add(dpt2.ToString());
            lista.Add(dpt3.ToString());
            listaPrincipal.ItemsSource = lista;

        }
	}
}