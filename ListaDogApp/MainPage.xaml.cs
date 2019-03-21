using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListaDogApp
{
    public partial class MainPage : ContentPage
    {
        List<Dog> doglist = new List<Dog>();

        void SaveDog(object sender, System.EventArgs e)
        {
            Dog dog = new Dog();

            if(label.name.Text == null)

            dog.nome  = label_name.Text;
            dog.idade = label_age.Text;
            dog.raca  = label_breed.Text;


            doglist.Add(dog);

            label_name.Text  = string.Empty;
            label_age.Text   = string.Empty;
            label_breed.Text = string.Empty;
        }

        void ShowDog(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyDogList(doglist));
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
