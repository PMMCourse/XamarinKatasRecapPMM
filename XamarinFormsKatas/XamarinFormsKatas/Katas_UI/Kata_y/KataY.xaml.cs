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
        List<string> listaPersonas = new List<string>();
		public KataY ()
		{
			InitializeComponent ();

            listaPersonas.Add("Martin");
            listaPersonas.Add("Antonio");
            listaPersonas.Add("Luisa");
            listaPersonas.Add("Vicente");
            listaPersonas.Add("Vicenta");
            listaPersonas.Add("Martina");
            listaPersonas.Add("Javier");
            listaPersonas.Add("Manuel");
            listaPersonas.Add("Juan");
            listaPersonas.Add("Carlos");
            listaPersonas.Add("Nacho");
            listaPersonas.Add("Marta");
            listaPersonas.Add("Natalia");
            listaPersonas.Add("Jose");
            listaPersonas.Add("Lola");
            listaPersonas.Add("Paula");
            listaPersonas.Add("Eugenia");
            listaPersonas.Add("Luis");
            listaPersonas.Add("Laura");
            listaPersonas.Add("Sonia");

            Grid grid = new Grid()
            {

            };
            grid.RowDefinitions = new RowDefinitionCollections();
            grid.ColumnDefinitions = new ColumnDefinitionCollections();

            for(int i = 0; i < 3; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 8; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            pagina.Children.Add(grid);

            int cont = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (cont < 20)
                    {
                        grid.Children.Add(new Label
                        {
                            Text = lista[cont],
                            HorizontalOptions = LayoutOptions.Center
                        }, j, i);
                        contador++;
                    }
                }
            }
        }

	}
}