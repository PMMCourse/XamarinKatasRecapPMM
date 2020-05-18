using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_z
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataZ : ContentPage
    {
        public KataZ()
        {
            InitializeComponent();
			List<string> ListaCadenas = new List<string>();

			var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			var stringChars = new char[8];
			var random = new Random();

			for (int a = 0; a < 20; a++)
			{
				for (int i = 0; i < stringChars.Length; i++)
				{
					stringChars[i] = caracteres[random.Next(caracteres.Length)];
				}
				ListaCadenas.Add(new String(stringChars));
			}

			ListaCadenas.Sort();

			var col = 0;
			var row = 0;
			foreach (string cadena in ListaCadenas)
			{

				BoxView box = new BoxView() {
					BackgroundColor = Color.Blue,
					WidthRequest = 50,
					HeightRequest = 50,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Start,
				};

				Label lab = new Label()
				{
					Text = cadena,
					FontSize = 24,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.FillAndExpand
				};

				var MyLayout = new StackLayout();
				MyLayout.Children.Add(box);
				MyLayout.Children.Add(lab);
				gridz.Children.Add(MyLayout, col, row);

				if (col < 2)
				{
					col++;
				}
				else
				{
					col = 0;
					row++;
				}
			}
		}
    }
}