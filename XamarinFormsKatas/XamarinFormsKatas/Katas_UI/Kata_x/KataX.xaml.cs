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
        Dictionary<string, int> lista = new Dictionary<string, int>() 
        {
            {"juan", 1}, {"juanca",2},
            {"sara", 3}, {"telefono", 4}
        };
        public KataX()
        {
            InitializeComponent();

            Picker picker = new Picker
            {
                Title = "Nombres",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            foreach (string nombre in lista.Keys)
            {
                picker.Items.Add(nombre);
            }


            Label label = new Label
            {
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            picker.SelectedIndexChanged += (sender, args) =>
            {
                if (picker.SelectedIndex == -1)
                {
                    label.Text = "";
                }
                else
                {
                    label.Text = picker.Items[picker.SelectedIndex];
                }
            };

            Sl.Children.Add(picker);
            Sl.Children.Add(label);
        }
    }
}