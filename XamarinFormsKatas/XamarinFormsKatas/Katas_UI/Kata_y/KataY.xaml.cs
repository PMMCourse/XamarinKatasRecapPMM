using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_y
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataY : ContentPage
	{
		public KataY()
		{
			InitializeComponent();
			List<string> ListaCadenas = new List<string>();

			var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			var stringChars = new char[8];
			var random = new Random();

			for (int a = 0; a < 20; a++) {
				for (int i = 0; i < stringChars.Length; i++)
				{
					stringChars[i] = caracteres[random.Next(caracteres.Length)];
				}
				ListaCadenas.Add(new String(stringChars));
			}

			ListaCadenas.Sort();

			foreach (string cadena in ListaCadenas)
			{
				Label label = new Label() { Text = cadena, Padding=10};
				this.FlexLay.Children.Add(label);
			}
		}
	}
}