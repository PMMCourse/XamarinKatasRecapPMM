using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
		public List<PersonaModel> Personas { get; private set; }

		public KataD ()
		{
			Personas = new List<PersonaModel>();
			Personas.Add(new PersonaModel { Nombre = "Fran", Edad = 19 });
			Personas.Add(new PersonaModel { Nombre = "Chema", Edad = 45 });
			Personas.Add(new PersonaModel { Nombre = "Otro", Edad = 28 });
			InitializeComponent();
			BindingContext = this;
		}
	}
}