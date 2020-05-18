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
		private string nombre;
		private string dni;
		private string producto;

		public List<string> listaDatos { get; private set; }

		public KataR()
		{
			InitializeComponent();

			listaDatos = new List<string>();
			for (int i = 1; i <= 5; i++) { 
				cliente person = new cliente(nombre = "Cliente"+i, dni = "DNI"+i);
				listaDatos.Add(person.Datos_Lista);
			}
			for (int i = 1; i <= 5; i++)
			{
				proveedor person = new proveedor(nombre = "Proveedor" + i, producto = "PRODUCTO" + i);
				listaDatos.Add(person.Datos_Lista);
			}

			InitializeComponent();
			BindingContext = this;
		}
	}
}