using HelloWorldProject.Models;
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
	public partial class AzureEditPage : ContentPage
	{
        Vehicle vehicleOnPage;
		public AzureEditPage (Vehicle vehicle)
		{
			InitializeComponent ();

            this.makeEntry.Text = vehicle.Make;
            this.modelEntry.Text = vehicle.Model;
            this.vehicleOnPage = vehicle;
		}

        private async void updateButton_Clicked(object sender, EventArgs e)
        {
            vehicleOnPage.Make = makeEntry.Text;
            vehicleOnPage.Model = modelEntry.Text;

            await GlobalConfig.MobileService.GetTable<Vehicle>().UpdateAsync(vehicleOnPage);
            
            Navigation.PopAsync();
        }
    }
}