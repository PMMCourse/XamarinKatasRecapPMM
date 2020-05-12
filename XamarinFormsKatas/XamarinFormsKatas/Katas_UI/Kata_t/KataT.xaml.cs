using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataT : ContentPage
	{
		public List<Athlete> List = new List<Athlete>();
		public KataT()
		{
			InitializeComponent();
			Athlete player1 = new Athlete(9, 35, "CR7", "Fútbol");
			Athlete player2 = new Athlete(7, 38, "Joaquin", "Fútbol");
			Athlete player3 = new Athlete(10, 33, "Messi", "Fútbol");
			List.Add(player1);
			List.Add(player2);
			List.Add(player3);
			athleteList.ItemsSource = List;
		}
	}
}