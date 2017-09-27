using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<string> TodoItems { get; set; }

        public TodoPage()
        {
            InitializeComponent();

            this.TodoItems = new ObservableCollection<string>();
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

            todoList.ItemsSource = this.TodoItems;
        }

        private void deleteItem_Clicked(object sender, EventArgs e)
        {
            MenuItem mi = ((MenuItem)sender);
            string item = mi.CommandParameter.ToString();

            this.TodoItems.Remove(item);

            todoList.ItemsSource = this.TodoItems;
        }

        private void todoList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            string item = e.SelectedItem.ToString();

            ((ListView)sender).SelectedItem = null;

            Navigation.PushAsync(new ToDoDetail(item));
        }
    }
}