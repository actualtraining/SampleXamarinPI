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
    public partial class BindingToDataModel : ContentPage
    {
        public BindingToDataModel()
        {
            InitializeComponent();
            BindingContext = new BeritaViewModel();
        }

        private void ListBerita_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (Berita)e.Item;
            DisplayAlert("Keterangan", "Anda memilih berita dengan Judul " + data.Judul, "OK");
        }
    }
}