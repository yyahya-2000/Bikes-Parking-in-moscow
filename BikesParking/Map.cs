using System;
using System.Windows.Forms;
using Microsoft.Maps.MapControl.WPF;

namespace BikesParking
{
    public partial class Map : Form
    {
        MapUserControl mapUser = new MapUserControl();
        public Map(double latitude, double longitude)
        {
            InitializeComponent();
            Pushpin pin = new Pushpin();
            pin.Location = new Location(latitude, longitude);
            mapUserControl1.Map.SetView(new Location(latitude, longitude), 16);
            mapUserControl1.Map.Children.Add(pin);
        }

    }
}
