using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace Mapita
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GeneratePins();
            
        }
        private void GeneratePins()
        {
            var pins = new List<Pin>
            {
                new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.87) },
                new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.77) },
                new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.97) },
            };

            foreach (var pin in pins)
            {
                // Podemos usar FromBundle, FromStream o FromView (custom view)
                //pin.Icon = BitmapDescriptorFactory.FromBundle("coffee_pin.png");
                map.Pins.Add(pin);
            }
        }
    }
}
