using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_m
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	
	public partial class KataM : ContentPage
	{
		private int contador;

		public int Contador
		{
			get { return contador; }
			set { contador = value; }
		}

		public KataM ()
		{
			InitializeComponent ();
		}

		private void BtnAddLabel(object sender, EventArgs e)
		{
			contador++;
			Label label = new Label() { Text = "Etiqueta" + contador.ToString() };
			this.EjerMlayout.Children.Add(label);
		}

	}
}