using System.IO;
using System.Windows;
using Microsoft.Win32;
using LagerverwaltungApp.Models;

namespace LagerverwaltungApp
{
    public partial class ArtikelDialog : Window
    {
        private byte[] bildBytes;

        public ArtikelDialog()
        {
            InitializeComponent();
        }

        private void BildWaehlen_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Bilder|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == true)
            {
                bildBytes = File.ReadAllBytes(dialog.FileName);
            }
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            var artikel = new Artikel
            {
                Name = NameBox.Text,
                Ort = OrtBox.Text,
                Regal = RegalBox.Text,
                Kiste = KisteBox.Text,
                Schublade = SchubladeBox.Text,
                Schrank = SchrankBox.Text,
                Anwendung = AnwendungBox.Text,
                InternetHinweis = HinweisBox.Text,
                Bild = bildBytes
            };

            // Menge parsen
            if (int.TryParse(MengeBox.Text, out int menge))
                artikel.Menge = menge;
            else
                artikel.Menge = 0;

            // Speichern in DB
            App.DbContext.Artikel.Add(artikel);
            App.DbContext.SaveChanges();

            MessageBox.Show("Artikel gespeichert!");
            this.Close();
        }
    }
}
