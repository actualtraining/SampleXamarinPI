using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Latihan1.ViewModels;

namespace Latihan1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomListPage : ContentPage
    {
        public CustomListPage()
        {
            InitializeComponent();
            BindingContext = new BeritaViewModel(DisplayAlert);

            btnBack.Clicked += BtnBack_Clicked;
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}