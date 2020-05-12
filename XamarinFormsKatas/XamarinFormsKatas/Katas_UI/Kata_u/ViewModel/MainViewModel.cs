using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_u.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        private Map _map;
        public Map map
        {
            get => _map;
            set
            {
                _map = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            _map = new Map(MapSpan.FromCenterAndRadius(new Position(37.393355, -5.983900), Distance.FromMiles(1)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var pFesac = new Position(37.371861, -5.999654);
            var pcampoFutbol = new Position(37.384217, -5.993467);
            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = pFesac,
                Label = "Fesac"
            };
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = pcampoFutbol,
                Label = "Campo Futbol"
            };
            _map.Pins.Add(pin1);
            _map.Pins.Add(pin2);
            mapaPrincipal.Children.Add(_map);
        }
    }
}
