﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Latihan1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            InitializeComponent();
            masterPageMenu.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageMenuItem;
            if (item != null)
            {
                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;
                Detail = new NavigationPage(page);
                masterPageMenu.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}