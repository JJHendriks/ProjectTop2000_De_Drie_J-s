using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BusinessLayer;
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
            //dgArtistsRemove.ItemsSource = Procedures.GetEmptyArtists();
            
        }

        private void tabmenu_clicked(object sender, MouseButtonEventArgs e)
        {
            Window window = new AdminHub();
            window.Show();
            this.Hide();
        }

        private void dgEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Artist artiest = (Artist)dgEdit.SelectedValue;
            //string artiest_naam = artiest.Artist_Name;
            //dgArtistSongs.ItemsSource = Procedures.GetSongsFromArtist(artiest_naam);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Aanpassingen aan een artiest opslaan
            Artist artiest = (Artist)dgEdit.SelectedValue;
            int artiest_id = artiest.Artist_ID;

            Procedures.EditArtist(artiest_id, tbNameEdit.Text, tbInfoEdit.Text);
            dgEdit.ItemsSource = Procedures.GetArtists();
            tbNameEdit.Text = "";
            tbInfoEdit.Text = "";
            tbSearchEdit.Clear();
            this.dgEdit.Columns[2].Visibility = Visibility.Hidden;


        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Procedures.AddArtist(tbNameAdd.Text, tbInfoAdd.Text);
            dgArtistAdd.ItemsSource = Procedures.CertainArtist();
            this.dgArtistAdd.Columns[2].Visibility = Visibility.Hidden;
            tbNameAdd.Text = "";
            tbInfoAdd.Text = "";

        }

        private void tbSearchRemove_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filterText = tbSearchRemove.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dgArtistsRemove.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    Artist p = o as Artist;
                    return (p.Artist_Name.ToUpper().Contains(filterText.ToUpper()));
                };
            }
            else
            {
                cv.Filter = null;
            }
        }

        private void tbSearchEdit_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filterText = tbSearchEdit.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dgEdit.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    Artist p = o as Artist;
                    //Als een artist name de filter tekens bevat wordt hij getoont.
                    return (p.Artist_Name.ToUpper().Contains(filterText.ToUpper()));
                };
            }
            else
            {
                //Zorgen dat als er geen text staat er niet gefilterd word.
                cv.Filter = null;
            }
        }

      
    }
}
