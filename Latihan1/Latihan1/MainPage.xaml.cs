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
		}

        private void BtnTambah_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Keterangan", "Tombol Tambah Dipilih !", "OK");
        }
    }
}
