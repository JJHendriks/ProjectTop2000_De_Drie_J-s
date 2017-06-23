using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

            //IMPORTANT CODE IS WORK IS PROGRESS.

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter = "Text Document (.txt|*.txt";
            if (ofd.ShowDialog() == true) { 
                var list = new List<BusinessLayer.Lijst>();
                using (StreamReader reader = File.OpenText(ofd.FileName))
                {
                    string str = File.ReadAllText(ofd.FileName);
                    MessageBox.Show(str);
                }
            }
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
