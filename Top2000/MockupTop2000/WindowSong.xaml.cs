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
    /// Interaction logic for WindowSong.xaml
    /// </summary>
    public partial class WindowSong : Window
    {
        public WindowSong()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            dgSongs.ItemsSource = Procedures.GetSongs();
            dgArtistEdit.ItemsSource = Procedures.GetArtists();
            dgArtistAdd.ItemsSource = Procedures.GetArtists();
        }

        #region TabEdit 

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Song song = (Song)dgSongs.SelectedValue;
            dgArtistEdit.ItemsSource = Procedures.SelectArtist(song.Artist_id);
            Artist artist = (Artist)dgArtistEdit.SelectedValue;
            Procedures.EditSong(song.Song_ID, (int)dgArtistEdit.SelectedItem, tbNameEdit.Text, tbYearEdit.Text);
        }

        private void dgSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Song song = (Song)dgSongs.SelectedValue;
            tbNameEdit.Text = song.Artist_name;
            tbYearEdit.Text = song.Year.ToString();
        }

        private void tbSearchArtistEdit_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filterText = tbSearchArtistEdit.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dgArtistEdit.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    Artist p = o as Artist;
                    //Als een lied de filter tekens bevat wordt hij getoont.
                    return (p.Artist_Name.ToUpper().Contains(filterText.ToUpper()));
                };
            }
            else
            {
                //Zorgen dat als er geen text staat er niet gefilterd word.
                cv.Filter = null;
            }
        }


        #endregion

        #region tabDelete 

        #endregion

        #region tabAdd 
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Artist artist = (Artist)dgArtistAdd.SelectedValue;
            Procedures.AddSong(artist.Artist_ID, tbNameAdd.Text, tbYearAdd.Text);
            dgAddSongs.ItemsSource = Procedures.CertainSong();
            this.dgAddSongs.Columns[1].Visibility = Visibility.Hidden;
            this.dgAddSongs.Columns[2].Visibility = Visibility.Hidden;
            tbNameAdd.Clear();
            tbSearchArtistAdd.Clear();
            tbYearAdd.Clear();
            MessageBox.Show("De song is succesvol toegevoegd!");
        }

        private void tabmenu_clicked(object sender, MouseButtonEventArgs e)
        {
            Window window = new AdminHub();
            window.Show();
            this.Hide();
        }

        private void tbSearchArtistAdd_TextChanged(object sender, TextChangedEventArgs e)
        {

            string filterText = tbSearchArtistAdd.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dgArtistAdd.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    Artist p = o as Artist;
                    //Als een lied de filter tekens bevat wordt hij getoont.
                    return (p.Artist_Name.ToUpper().Contains(filterText.ToUpper()));
                };
            }
            else
            {
                //Zorgen dat als er geen text staat er niet gefilterd word.
                cv.Filter = null;
            }
        }

        #endregion
    }
}
