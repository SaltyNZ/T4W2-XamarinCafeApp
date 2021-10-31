using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CafeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void BreakfastButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksPage());
        }

        private async void LunchButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinksPage());
        }

        private async void DrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBitesPage());
        }

        private async void EspressoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinksInfoPage());
        }
    }
}