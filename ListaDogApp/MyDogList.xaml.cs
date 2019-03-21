using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaDogApp
{
    public partial class MyDogList : ContentPage
    {
        void Voltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public MyDogList(List<Dog> doglist)
        {
            InitializeComponent();
            DogList.ItemsSource = doglist;
        }
    }
}
