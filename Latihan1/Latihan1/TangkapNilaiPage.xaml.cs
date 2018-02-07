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

        private string name;
        private string address;
        public TangkapNilaiPage(string name,string address)
        {
            InitializeComponent();
            this.name = name;
            this.address = address;
        }

        protected override void OnAppearing()
        {
            lblKeterangan.Text = "Nama: " + name + " Address: " + address;
        }
    }
}