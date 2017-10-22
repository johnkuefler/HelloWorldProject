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
	public partial class ExtendedListViewPage : ContentPage
	{
        public ObservableCollection<Animal> Animals { get; set; }

		public ExtendedListViewPage ()
		{
			InitializeComponent ();

            this.Animals = new ObservableCollection<Animal>();
            Animal gorilla = new Animal
            {
                Description = "The best animal",
                Name = "Gorilla",
                ImageURL = "https://i.pinimg.com/236x/ce/69/c1/ce69c1795b4afaf1ff993b79adb3a5de--western-lowland-gorilla-the-gorilla.jpg"
            };
            this.Animals.Add(gorilla);

            Animal tiger = new Animal
            {
                Description = "Orange with black stripes",
                Name = "Tiger",
                ImageURL = "https://68.media.tumblr.com/avatar_71382c4baeb0_128.png",
            };
            this.Animals.Add(tiger);

            Animal zebra = new Animal
            {
                Description = "White with black stripes",
                Name = "Zebra",
                ImageURL = "https://images2.storyjumper.com/transcoder.png?trim&id=6g-kjfpa8wo45-58pw0cclj&maxw=256&maxh=256"
            };
            this.Animals.Add(zebra);

            this.extendedListView.ItemsSource = this.Animals;
		}

        private void extendedListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // make sure the selected item is not null
            if (e.SelectedItem == null)
            {
                return; 
            }

            // grab the selected item as our Animal class
            Animal selectedAnimal = e.SelectedItem as Animal;

            // deselect the item in the list
            (sender as ListView).SelectedItem = null;

            // Send the animal to the detail page
            Navigation.PushAsync(new AnimalPage(selectedAnimal));
        }
    }



    public class Animal
    {
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}