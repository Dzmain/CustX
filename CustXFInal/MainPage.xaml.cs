using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustXFInal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count1 = 0;
        int count2 = 0;
        private async void TU_Clicked(object sender, EventArgs e)
        {
            count1++;
            await Navigation.PushAsync(new Page2());

        }
        private async void TD_Clicked(object sender, EventArgs e)
        {
            count2++;
            await Navigation.PushAsync(new TDF2());

        }
    }
}
