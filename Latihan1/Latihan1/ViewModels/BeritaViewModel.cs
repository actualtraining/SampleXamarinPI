using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Latihan1.ViewModels
{
    public class BeritaViewModel : BindableObject
    {
        private Func<string, string, string,string,Task<bool>> displayAlert;

        private ObservableCollection<Berita> listBerita;
        public ObservableCollection<Berita> ListBerita
        {
            get { return listBerita; }
            set { listBerita = value; OnPropertyChanged("ListBerita"); }
        }

        public BeritaViewModel(Func<string,string,string,string, Task<bool>> displayAlert)
        {

            this.displayAlert = displayAlert;

            listBerita = new ObservableCollection<Berita>()
            {
                new Berita{Judul="Belajar Xamarin Forms",Keterangan="Belajar menggunakan listview di Xamarin",
                Gambar="monkey1.png",Pengarang="Budi",Tanggal=new DateTime(2018,2,7)},
                new Berita{Judul="Menggunakan Layanan One Signal",Keterangan="Menggunakan One Signal untuk layanan push notification",
                Gambar="monkey2.png",Pengarang="Amir",Tanggal=new DateTime(2018,2,17)},
                new Berita{Judul="ASP.NET Web API",Keterangan="Menggunakan Web API untuk backend",
                Gambar="monkey3.png",Pengarang="Ani",Tanggal=new DateTime(2018,2,10)}
            };

            MessagingCenter.Subscribe<Berita>(this, "EditRequested", EditRequested);
            MessagingCenter.Subscribe<Berita>(this, "DeleteRequested", DeleteRequested);
        }

        private async void DeleteRequested(Berita obj)
        {
            bool result = await displayAlert.Invoke("Konfirmasi", "Apakah data " + obj.Judul + " yakin akan di delete", "Yes","No");
            if (result)
            {
                listBerita.Remove(obj);
            }
        }

        private void EditRequested(Berita obj)
        {
            obj.Judul += " - diedit";
            //obj.Pengarang += "- diedit";
            displayAlert.Invoke("Tombol Edit", obj.Judul + " dipilih", "OK","Cancel");
        }
    }
}
