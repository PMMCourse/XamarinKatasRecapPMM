using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataJ : ContentPage
	{
        public KataJ()
        {
            InitializeComponent();

        }

        private void Accept_Clicked(object sender, EventArgs e)
        {
            if (User.Text == String.Empty)
            {
                Entry error = new Entry();
                error.Text = "ERROR, USER IS NEEDED";

                contenedor.Children.Add(error);
            }
            if (Password.Text == String.Empty)

            {
                Entry error = new Entry();
                error.Text = "ERROR, PASSWORD IS NEEDED";
                contenedor.Children.Add(error);
            }

        }

    }
}