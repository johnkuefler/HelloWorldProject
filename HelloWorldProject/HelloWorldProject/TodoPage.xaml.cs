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
    public partial class TodoPage : ContentPage
    {
        public List<string> TodoItems { get; set; }

        public TodoPage()
        {
            InitializeComponent();

            this.TodoItems = new List<string>();
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newTodoItemEntry.Text))
            {
                DisplayAlert("Error", "Please enter a value", "Ok");
            }
            else
            {
                this.TodoItems.Add(newTodoItemEntry.Text);

                todoList.ItemsSource = this.TodoItems;

                newTodoItemEntry.Text = "";
            }
        }

        private void clearItemsButton_Clicked(object sender, EventArgs e)
        {
            this.TodoItems.Clear();

            todoList.ItemsSource = new List<string>();
        }
    }
}