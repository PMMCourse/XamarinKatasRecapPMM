using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_x
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataX : ContentPage
	{
        List<int> lista = new List<int>();
		public KataX ()
		{
			InitializeComponent ();
		}
        public void CrearObjeto(objeto sender, FocusEventArgs e)
        {
            var objeto = new Picker();
            objeto.ItemsSource = lista;
            ejercicio.Children.Add(objeto);
        }
        public void rellenarLista()
        {
            lista.Add(28);
            lista.Add(16);
            lista.Add(5);
            lista.Add(12);
            lista.Add(33);
        }
    }
}