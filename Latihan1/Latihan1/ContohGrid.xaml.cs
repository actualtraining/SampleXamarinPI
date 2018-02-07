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
        }

        private async void BtnKirim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TangkapNilaiPage(txtName.Text, txtAddress.Text));
        }
    }
}