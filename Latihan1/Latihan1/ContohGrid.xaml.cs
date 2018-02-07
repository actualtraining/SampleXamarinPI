using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Latihan1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContohGrid : ContentPage
    {
        public ContohGrid()
        {
            InitializeComponent();
            btnKirim.Clicked += BtnKirim_Clicked;
            btnUsername.Clicked += BtnUsername_Clicked;
            btnDisplaySheet.Clicked += BtnDisplaySheet_Clicked;
        }

        private async void BtnDisplaySheet_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Options", "Cancel", null,
                "C#", "Java", "Kotlin", "Go", "Erlang");
            await DisplayAlert("Keterangan", "Anda memilih: " + action, "OK");
        }

        private async void BtnUsername_Clicked(object sender, EventArgs e)
        {
            string username = App.Current.Properties["Username"].ToString();

            App.Current.Properties["Username"] = "budi";
            await DisplayAlert("Keterangan", "Username: " + username, "OK");
        }

        private async void BtnKirim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TangkapNilaiPage(txtName.Text, txtAddress.Text));
        }
    }
}