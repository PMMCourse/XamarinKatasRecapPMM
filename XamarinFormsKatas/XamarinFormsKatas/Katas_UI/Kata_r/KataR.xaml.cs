using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataR : ContentPage
	{
        List<string> ClientAndProviderList = new List<string>();

        public KataR()
        {
            InitializeComponent();

            Client client1 = new Client("Pepito", "987654321B");
            Client client2 = new Client("Jaimito", "123456789A");

            Provider provider1 = new Provider("Matutano", "Patatas");
            Provider provider2 = new Provider("HP", "PC");

            ClientAndProviderList.Add(client1.ToString());
            ClientAndProviderList.Add(client2.ToString());
            ClientAndProviderList.Add(provider1.ToString());
            ClientAndProviderList.Add(provider2.ToString());

            CandPList.ItemsSource = ClientAndProviderList;
        }
    }
}