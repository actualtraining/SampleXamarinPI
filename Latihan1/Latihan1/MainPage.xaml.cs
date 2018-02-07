using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Latihan1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnTambah.Clicked += BtnTambah_Clicked;

            btnNavigateToCustom.Clicked += BtnNavigateToCustom_Clicked;
            btnModal.Clicked += BtnModal_Clicked;
		}

        private async void BtnModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CustomListPage());
        }
        private async void BtnGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohGrid());
        }

        private async void BtnNavigateToCustom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomListPage());
        }

        private void BtnTambah_Clicked(object sender, EventArgs e)
        {
            //sample click event
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 + bil2;
            DisplayAlert("Keterangan",String.Format("Hasil {0}+{1}={2}",bil1,bil2,hasil), "OK");
        }
    }
}
