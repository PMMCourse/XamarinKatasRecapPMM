using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
		public IList<PersonaModel> Personas { get; private set; }

		public KataD ()
		{
			InitializeComponent();
			Personas = new List<PersonaModel>();
			Personas.Add(new PersonaModel { Nombre = "Fran", Edad = 19});
			Personas.Add(new PersonaModel { Nombre = "Chema", Edad = 45});
			Personas.Add(new PersonaModel { Nombre = "Otro", Edad = 28});
			BindingContext = this;
		}
	}
}