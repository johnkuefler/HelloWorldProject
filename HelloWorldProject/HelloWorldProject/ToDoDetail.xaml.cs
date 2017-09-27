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
    public partial class ToDoDetail : ContentPage
    {
        public ToDoDetail(string item)
        {
            InitializeComponent();

            this.itemLabel.Text = item;
        }
    }
}