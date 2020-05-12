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
		List<string> nameList = new List<string>();
		public KataX()
		{
			InitializeComponent();
			nameList.Add("DOG");
			nameList.Add("CAT");
			nameList.Add("MOUSE");
			nameList.Add("SNAKE");
			Entry1.Focused += ShowPicker;
		}

		private void ShowPicker(Object sender, EventArgs e)
		{
			Picker1.ItemsSource = nameList;
			Picker1.IsVisible = true;
		}
	}
}