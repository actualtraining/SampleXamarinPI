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
    public partial class MasterPageMenu : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPageMenu()
        {
            InitializeComponent();

            var masterPageItem = new List<MasterPageMenuItem>();
            masterPageItem.Add(new MasterPageMenuItem
            {
                Title = "Main Menu",
                IconSource = "icon.png",
                TargetType = typeof(MainPage)
            });
            masterPageItem.Add(new MasterPageMenuItem
            {
                Title = "Custom List",
                IconSource = "icon.png",
                TargetType = typeof(CustomListPage)
            });
            masterPageItem.Add(new MasterPageMenuItem
            {
                Title="Contoh Grid",
                IconSource = "icon.png",
                TargetType=typeof(ContohGrid)
            });

            listView.ItemsSource = masterPageItem;
        }
    }
}