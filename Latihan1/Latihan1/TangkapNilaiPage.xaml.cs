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
    public partial class TangkapNilaiPage : ContentPage
    {
        public TangkapNilaiPage()
        {
            InitializeComponent();
        }

        private async void BtnUsername_Clicked(object sender, EventArgs e)
        {
            string username = App.Current.Properties["Username"].ToString();
            await DisplayAlert("Keterangan", "Username: " + username, "OK");
        }

        private string name;
        private string address;
        public TangkapNilaiPage(string name,string address)
        {
            InitializeComponent();
            this.name = name;
            this.address = address;

            btnUsername.Clicked += BtnUsername_Clicked;
        }

        protected override void OnAppearing()
        {
            lblKeterangan.Text = "Nama: " + name + " Address: " + address;
        }
    }
}