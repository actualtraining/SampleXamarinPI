using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Latihan1
{
    public class Berita : BindableObject
    {
        private string judul;
        public string Judul
        {
            get { return judul; }
            set { judul = value; OnPropertyChanged("Judul"); }
        }

        private string keterangan;
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; OnPropertyChanged("Keterangan"); }
        }

        private Command deleteCommand;
        public Command DeleteCommand
        {
            get { return deleteCommand; }
            set { deleteCommand = value; OnPropertyChanged("DeleteCommand"); }
        }

        private Command editCommand;

        public Command EditCommand
        {
            get { return editCommand; }
            set { editCommand = value; OnPropertyChanged("EditCommand"); }
        }

        public Berita()
        {
            DeleteCommand = new Command(DeleteRequested);
            EditCommand = new Command(EditRequested);
        }

        private void EditRequested(object obj)
        {
            MessagingCenter.Send<Berita>(this, "EditRequested");
        }

        private void DeleteRequested(object obj)
        {
            MessagingCenter.Send<Berita>(this, "DeleteRequested");
        }

        public string Pengarang { get; set; }
        public DateTime Tanggal { get; set; }
        public string Gambar { get; set; }
    }
}
