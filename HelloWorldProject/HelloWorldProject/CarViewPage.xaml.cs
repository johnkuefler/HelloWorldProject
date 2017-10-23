using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarViewPage : ContentPage
    {
        

        public CarViewPage(string color)
        {
            InitializeComponent();

            switch (color)
            {
                case "green":
                    carImage.Source = "https://i.pinimg.com/736x/87/f6/42/87f642c73089b046664eab9088940d17.jpg";
                    break;
                case "red":
                    carImage.Source = "http://eskipaper.com/images/awesome-red-car-2.jpg";
                    break;
                case "blue":
                    carImage.Source = "https://i.pinimg.com/originals/7b/8a/70/7b8a70d10373c6cd461bc4e49537a16b.jpg";
                    break;
                default:
                    carImage.Source = "http://cdn.ebaumsworld.com/mediaFiles/picture/2183782/82186257.jpg";
                    break;
            }
        }
    }
}