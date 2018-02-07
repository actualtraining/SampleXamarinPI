using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Latihan1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContohMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public ContohMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new ContohMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ContohMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ContohMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public ContohMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ContohMasterDetailPageMenuItem>(new[]
                {
                    new ContohMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new ContohMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new ContohMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new ContohMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new ContohMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}