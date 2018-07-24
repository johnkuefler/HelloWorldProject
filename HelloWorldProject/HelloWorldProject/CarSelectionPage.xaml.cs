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
    public partial class CarSelectionPage : ContentPage
    {
        public CarSelectionPage()
        {
            InitializeComponent();
        }

        private void selectButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarViewPage(colorEntry.Text));
        }
    }
}