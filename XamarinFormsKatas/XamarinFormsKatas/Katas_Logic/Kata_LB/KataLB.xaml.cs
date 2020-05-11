using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLB : ContentPage
	{
		public KataLB ()
		{
			InitializeComponent ();
            LecturaJSON();
		}
        public async void LecturaJSON()
        {
            if (checking.Internet())
            {
                var cliente = new System.Net.Http.HttpClient();
                var responsable = await cliente.GetAsync("https://jsonplaceholder.typicode.com/posts");
                string usuarioJSON = await responsable.Content.ReadAsStringAsync();
                List<User> lista = new List<User>();
                if (string.IsNullOrEmpty(lista.ToString()))
                {
                    lista = JSonConvert.DeserializeObject<List<User>>(usuarioJSON);

                }
                list.ItemsSource = usuarioJSON;
            }
            else
            {
                await DisplayAlert("not Json", "el json es invalido", "ok");
            }
        }
	}
}