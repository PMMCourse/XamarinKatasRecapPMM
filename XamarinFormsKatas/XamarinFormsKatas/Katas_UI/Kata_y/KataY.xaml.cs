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
        public List<string> stringList = new List<string>();
        public KataY()
        {
            InitializeComponent();
            stringList.Add("STRING1");
            stringList.Add("STRING2");
            stringList.Add("STRING3");
            stringList.Add("STRING4");
            stringList.Add("STRING5");
            stringList.Add("STRING6");
            stringList.Add("STRING7");
            stringList.Add("STRING8");
            stringList.Add("STRING9");
            stringList.Add("STRING10");
            stringList.Add("STRING11");
            stringList.Add("STRING12");
            stringList.Add("STRING13");
            stringList.Add("STRING14");
            stringList.Add("STRING15");
            stringList.Add("STRING16");
            stringList.Add("STRING17");
            stringList.Add("STRING18");
            stringList.Add("STRING19");
            stringList.Add("STRING20");

            Grid grid1 = new Grid()
            {

            };


            grid1.RowDefinitions = new RowDefinitionCollection();
            grid1.ColumnDefinitions = new ColumnDefinitionCollection();

            for (int i = 0; i < 3; i++)
            {
                grid1.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 8; i++)
            {
                grid1.ColumnDefinitions.Add(new ColumnDefinition());
            }

            STL1.Children.Add(grid1);

            int cnt = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (cnt < 20)
                    {
                        grid1.Children.Add(new Label
                        {
                            Text = stringList[cnt],
                            HorizontalOptions = LayoutOptions.Center
                        }, j, i);
                        cnt++;
                    }
                }
            }
        }

    }
}