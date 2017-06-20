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

namespace MockupTop2000
{
    /// <summary>
    /// Interaction logic for AdminHub.xaml
    /// </summary>
    public partial class AdminHub : Window
    {
        public AdminHub()
        {
            InitializeComponent();
        }

        private void btnLijst_Click(object sender, RoutedEventArgs e)
        {
            //importeer een lijst uit een tekst bestand
        }

        private void btnArtiest_Click(object sender, RoutedEventArgs e)
        {
            //navigeer naar het artiesten scherm
            Window window = new WindowArtist();
            window.Show();
            this.Hide();
        }

        private void btnSong_Click(object sender, RoutedEventArgs e)
        {
            //navigeer naar het song scherm
            Window window = new WindowSong();
            window.Show();
            this.Hide();
        }
    }
}
