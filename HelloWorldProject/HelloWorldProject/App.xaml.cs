using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorldProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Settings.UserData != null)
            {
                GlobalConfig.LoggedInUser = Settings.UserData;
            }

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
