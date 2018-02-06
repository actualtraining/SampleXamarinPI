using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Latihan1.ViewModels
{
    public class BeritaViewModel : BindableObject
    {
        private List<Berita> listBerita;
        public List<Berita> ListBerita
        {
            get { return listBerita; }
            set { listBerita = value; OnPropertyChanged("ListBerita"); }
        }

        public BeritaViewModel()
        {
            listBerita = new List<Berita>()
            {
                new Berita{Judul="Belajar Xamarin Forms",Keterangan="Belajar menggunakan listview di Xamarin",
                Gambar="monkey1.png"},
                new Berita{Judul="Menggunakan Layanan One Signal",Keterangan="Menggunakan One Signal untuk layanan push notification",
                Gambar="monkey2.png"},
                new Berita{Judul="ASP.NET Web API",Keterangan="Menggunakan Web API untuk backend",
                Gambar="monkey3.png"}
            };

        }
    }
}
