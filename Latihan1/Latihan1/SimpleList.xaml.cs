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
    public partial class SimpleList : ContentPage
    {
        private List<string> lstNama;

        public SimpleList()
        {
            InitializeComponent();
            lstNama = new List<string>
            {
                "Budi","Bambang","Joko","Amir","Ani"
            };

            lvData.ItemsSource = lstNama;

            lvData.ItemTapped += LvData_ItemTapped;
        }

        private void LvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string strNama = (string)e.Item.ToString();
            DisplayAlert("Keterangan", "Anda memilih data " + strNama,"OK");

            ((ListView)sender).SelectedItem = null;
        }
    }
}