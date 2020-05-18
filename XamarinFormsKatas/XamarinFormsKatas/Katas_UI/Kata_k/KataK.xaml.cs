using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace XamarinFormsKatas.Katas_UI.Kata_k
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataK : ContentPage
	{
		public ObservableCollection<string> ListaK = new ObservableCollection<string>();

		public KataK ()
		{
			InitializeComponent();
			BindingContext = this;

			listviewK.RefreshCommand = new Command(() => {
				listviewK.IsRefreshing = true;
				RefreshData();
				listviewK.IsRefreshing = false;
			});
		}
		public void RefreshData()
		{
			var num_actual = ListaK.Count();
			var NumItem = 0;
			for (int i = 1; i <= 10; i++)
			{
				NumItem = num_actual + i;
				ListaK.Add("Item " + NumItem);
			}
			listviewK.ItemsSource = ListaK;
		}
	}
}