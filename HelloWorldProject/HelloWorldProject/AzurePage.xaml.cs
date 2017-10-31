﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace HelloWorldProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AzurePage : ContentPage
    {
        ObservableCollection<Vehicle> carList;

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            List<Vehicle> databaseCars = await GlobalConfig.MobileService.GetTable<Vehicle>().Where(rec => true).ToListAsync();
            this.carList = new ObservableCollection<Vehicle>(databaseCars);

            this.vehicleListView.ItemsSource = this.carList;
        }

        public AzurePage()
        {
            InitializeComponent();

            carList = new ObservableCollection<Vehicle>();
        }

        private async void addVehicleButton_Clicked(object sender, EventArgs e)
        {
            Vehicle car = new Vehicle();
            car.Make = makeEntry.Text;
            car.Model = modelEntry.Text;

           await GlobalConfig.MobileService.GetTable<Vehicle>().InsertAsync(car);

            makeEntry.Text = "";
            modelEntry.Text = "";

            this.carList.Add(car);
            this.vehicleListView.ItemsSource = this.carList;
        }
    }
}