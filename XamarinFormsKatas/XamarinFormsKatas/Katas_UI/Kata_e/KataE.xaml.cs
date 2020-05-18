using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataE : ContentPage
	{
		public List<PersonaModelE> PersonasE { get; private set; }

		public KataE()
		{
			PersonasE = new List<PersonaModelE>();
			PersonasE.Add(new PersonaModelE { Nombre = "Fran", Edad = 19, FotoUrl = "https://avatars0.githubusercontent.com/u/47655696?s=460&u=e6d2c387a0e085f5fb7199bc82799415b658815b&v=4" });
			PersonasE.Add(new PersonaModelE { Nombre = "Chema", Edad = 45, FotoUrl = "https://avatars2.githubusercontent.com/u/4325509?s=460&u=869e061c45ee120ce9b36bd89e18b7ed3277687a&v=4" });
			PersonasE.Add(new PersonaModelE { Nombre = "Otro", Edad = 28, FotoUrl = "https://customer-stories-feed.github.com/customer_stories/yyx990803/hero.jpg" });
			InitializeComponent();
			BindingContext = this;
		}

		private async void OnSelectedItem(object sender, ItemTappedEventArgs e)
		{
			var PersonaSeleccionada = e.Item as PersonaModelE;
			await Navigation.PushAsync(new DetallePersona(PersonaSeleccionada.Nombre, PersonaSeleccionada.Edad, PersonaSeleccionada.FotoUrl));
		}
	}
}