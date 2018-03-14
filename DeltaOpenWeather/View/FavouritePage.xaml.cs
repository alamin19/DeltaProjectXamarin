using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeltaOpenWeather.View
{
    public partial class FavouritePage : ContentPage
    {
        public FavouritePage()
        {
            InitializeComponent();
        }

        async void Handle_Appearing(object sender, System.EventArgs e)
        {
            // Reset the 'resume' id, since we just want to re-start here
            ((App)Application.Current).ResumeAtWeatherId = -1;

            var list = await App.Database.GetItemsAsync();

            if (list != null && list.Count > 0)
            {

                listView.ItemsSource = list;
            }
            else
            {
                await DisplayAlert("Altert", "No Item exits in favourite list", "Ok");
            }


           
        }


    }
}
