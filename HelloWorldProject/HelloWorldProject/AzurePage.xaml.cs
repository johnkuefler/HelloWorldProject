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
    public partial class AzurePage : ContentPage
    {
        public ObservableCollection<Models.Animal> Animals { get; set; }

        protected async override void OnAppearing() 
        {
            base.OnAppearing();

            List<Models.Animal> temp = await GlobalConfig.MobileService.GetTable<Models.Animal>()
                .Where(rec => true).ToListAsync();

            this.Animals = new ObservableCollection<Models.Animal>(temp);

            this.animalListView.ItemsSource = this.Animals;
        }

        public AzurePage()
        {
            InitializeComponent();

            this.Animals = new ObservableCollection<Models.Animal>();
        }

        private async void addAnimalButton_Clicked(object sender, EventArgs e)
        {
            Models.Animal animal = new Models.Animal {
                Description = animalDescEntry.Text,
                Name = animalNameEntry.Text
            };

            await GlobalConfig.MobileService.GetTable<Models.Animal>().InsertAsync(animal);

            animalDescEntry.Text = "";
            animalNameEntry.Text = "";

            this.Animals.Add(animal);

            this.animalListView.ItemsSource = this.Animals;
        }
    }
}