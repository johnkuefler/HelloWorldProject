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
    public partial class InteractionsPage : ContentPage
    {
        public InteractionsPage()
        {
            InitializeComponent();

        }

        private void interactionButton_Clicked(object sender, EventArgs e)
        {
            decimal result = Convert.ToDecimal(firstNumberEntry.Text) / Convert.ToDecimal(secondNumberEntry.Text);

            resultLabel.Text = result.ToString();
        }
    }
}