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
            BindingContext = new MainViewModel();
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

            Grid grid = new Grid
            {
                BackgroundColor = Color.Blue,
            HeightRequest = 500,
            WidthRequest=500
            };

            grid.RowDefinitions = new RowDefinitionCollection();
            grid.ColumnDefinitions = new ColumnDefinitionCollection();
            for (int i = 0; i < 7; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 3; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            pag.Children.Add(grid);
            int contador = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (contador < 20)
                    {
                        nuevoGrid.Children.Add(new Label
                        {
                            Text = lista[contador],
                            FontSize = 25,
                            HorizontalOptions = LayoutOptions.Center
                        }, j, i);
                        contador++;
                    }
                }
            }
        }
    }
}