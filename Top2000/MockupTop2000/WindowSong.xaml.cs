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
    /// Interaction logic for WindowSong.xaml
    /// </summary>
    public partial class WindowSong : Window
    {
        public WindowSong()
        {
            InitializeComponent();
        }
        private void tabmenu_clicked(object sender, MouseButtonEventArgs e)
        {
            Window window = new AdminHub();
            window.Show();
            this.Hide();
        }
    }
}
