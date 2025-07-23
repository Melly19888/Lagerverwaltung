using System.Linq;
using System.Windows;

namespace LagerverwaltungApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LadeDaten();
        }

        private void LadeDaten()
        {
            // Lädt alle Artikel und zeigt sie im DataGrid
            ArtikelGrid.ItemsSource = App.DbContext.Artikel.ToList();
        }

        private void BtnHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ArtikelDialog();
            dialog.ShowDialog();
            LadeDaten();
        }
    }
}
