using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_u1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataU1 : ContentPage
	{
		public KataU1 ()
		{
			InitializeComponent();
			MyMap.MoveToRegion(
				MapSpan.FromCenterAndRadius(
					new Position(37.373346, -5.985701),
					Distance.FromKilometers(2.5)
					)
				);
			Pin fesac = new Pin
			{
				Label = "Fesac",
				Address = "Avenida Flota de Indias, Sevilla",
				Type = PinType.Place,
				Position = new Position(37.371598, -6.0015763)
			};
			Pin sevilla = new Pin
			{
				Label = "Estadio Ramón Sánchez-Pizjuán",
				Address = "Calle Sevilla Fútbol Club",
				Type = PinType.Place,
				Position = new Position(37.3840655, -5.9728789)
			};
			Pin betis = new Pin
			{
				Label = "Estadio Benito Villamarín",
				Address = "Av de Heliópolis",
				Type = PinType.Place,
				Position = new Position(37.3565037, -5.9839408)
			};

			MyMap.Pins.Add(fesac);
			MyMap.Pins.Add(sevilla);
			MyMap.Pins.Add(betis);
		}

	}
}