using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataLayer;

namespace MockupTop2000
{
    /// <summary>
    /// Interaction logic for WindowArtist.xaml
    /// </summary>
    public partial class WindowArtist : Window
    {
        public WindowArtist()
        {
            InitializeComponent();
            dgEdit.ItemsSource = Procedures.GetArtists();
            dgArtistsRemove.ItemsSource = Procedures.GetEmptyArtists();
        }

        private void tabmenu_clicked(object sender, MouseButtonEventArgs e)
        {
            Window window = new AdminHub();
            window.Show();
            this.Hide();
        }

        private void dgEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Aanpassingen aan een artiest opslaan
            //Procedures.EditArtist();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Procedures.AddArtist("een id?", tbNameAdd.Text, tbInfoAdd.Text);
            Procedures.SelectArtist();
        }
    }
}
