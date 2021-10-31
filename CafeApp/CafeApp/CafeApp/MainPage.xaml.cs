using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CafeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BreakfastButton_Clicked(object sender, EventArgs e)
        {

        }

        private void LunchButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void DrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinksInfoPage());
        }
    }
}
