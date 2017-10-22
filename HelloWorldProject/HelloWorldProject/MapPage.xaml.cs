using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace HelloWorldProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            MyMap.MoveToRegion(
            MapSpan.FromCenterAndRadius(
                new Position(37.413366, -94.705027), Distance.FromMiles(1)));
        }
    }
}