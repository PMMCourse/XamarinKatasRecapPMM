using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataR : ContentPage
	{
        List<string> listaElementos = new List<string>();
		public KataR ()
		{
			InitializeComponent ();
            Cliente cliente1 = new Cliente("Marina","15225124R");
            Cliente cliente2 = new Cliente("Juan", "51824562G");
            Cliente cliente3 = new Cliente("Luisa", "19751999F");
            Proveedores proveedor1 = new Proveedores("Ramon", "Jamon");
            Proveedores proveedor2 = new Proveedores("Eduardo", "Licores");
            Proveedores proveedor3 = new Proveedores("Paula", "Flores");
            listaElementos.Add(cliente1.ToString());
            listaElementos.Add(cliente2.ToString());
            listaElementos.Add(cliente3.ToString());
            listaElementos.Add(proveedor1.ToString());
            listaElementos.Add(proveedor2.ToString());
            listaElementos.Add(proveedor3.ToString());

            listaPrincipal.ItemsSource = listaElementos;
        }
	}
}