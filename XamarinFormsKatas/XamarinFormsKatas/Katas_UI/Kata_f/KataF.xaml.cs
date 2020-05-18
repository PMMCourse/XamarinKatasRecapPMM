using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataF : ContentPage
	{

		public List<PersonaModelF> PersonasF { get; private set; }

		public KataF()
		{
			PersonasF = new List<PersonaModelF>();
			PersonasF.Add(new PersonaModelF { Nombre = "Fran", Edad = 19 });
			PersonasF.Add(new PersonaModelF { Nombre = "Chema", Edad = 45 });
			PersonasF.Add(new PersonaModelF { Nombre = "Otro", Edad = 28 });
			InitializeComponent();
			BindingContext = this;
		}

		private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
		{
			listviewF.BeginRefresh();
			if (string.IsNullOrWhiteSpace(e.NewTextValue))
				listviewF.ItemsSource = PersonasF;
			else
				listviewF.ItemsSource = PersonasF.Where(i => i.Nombre.ToLower().Contains(e.NewTextValue.ToLower()));
			listviewF.EndRefresh();
		}


	}
}