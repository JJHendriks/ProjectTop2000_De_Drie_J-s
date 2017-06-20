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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void AdminHub_OnClosing(object sender, CancelEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
        }

        private void btnSong_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WindowSong();
            window.Show();
            this.Hide();
        }

        private void btnArtiest_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WindowArtist();
            window.Show();
            this.Hide();
        }
    }
}
