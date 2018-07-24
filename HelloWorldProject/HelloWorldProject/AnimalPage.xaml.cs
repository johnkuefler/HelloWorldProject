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
    public partial class AnimalPage : ContentPage
    {
        public AnimalPage(Animal animal)
        {
            InitializeComponent();

            this.animalImage.Source = animal.ImageURL;
            this.nameLabel.Text = animal.Name;
            this.descriptionLabel.Text = animal.Description;
            this.weightLabel.Text = animal.Weight;
            this.heightLabel.Text = animal.Height;
            this.combatAbilityLabel.Text = animal.CombatAbility;
        }
    }
}