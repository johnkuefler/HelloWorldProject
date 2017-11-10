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
    public partial class LocalStoragePage : ContentPage
    {
        public LocalStoragePage()
        {
            InitializeComponent();

            // if the user data exists, load it to textboxes on the page
            if (Settings.UserData != null)
            {
                this.email.Text = Settings.UserData.EmailAddress;
                this.password.Text = Settings.UserData.Password;
            }
        }

        private void updateButton_Clicked(object sender, EventArgs e)
        {
            // initialize user object and set it to user data setting
            // this saves the user data over whatever was already there
            User userToSave = new User();
            userToSave.EmailAddress = this.email.Text;
            userToSave.Password = this.password.Text;

            Settings.UserData = userToSave;
        }
    }
}