using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_k
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataK : ContentPage
	{
        Random random = new Random();
        List<int> lista = new List<int>();

		public KataK ()
		{
			InitializeComponent ();
            LeerDatos();
            listaRefresh.RefreshCommand = new Command(() =>
              {
                  listaRefresh.IsRefreshing = true;
                  LeerDatos();
              });

        }
        private void LeerDatos()
        {
            LeerDatos.ItemsSource = null;
            lista.clear();
            for(int i = 0; i < 5; i++)
            {
                lista.Add(random.Next());
            }
            LeerDatos.ItemsSource = lista;
            LeerDatos.IsRefreshing = false;
        }
	}
}