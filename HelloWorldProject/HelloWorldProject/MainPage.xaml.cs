using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorldProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddItemPage());
        }

        private void backEndButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BackEndInteractionPage());
        }
    }
}
