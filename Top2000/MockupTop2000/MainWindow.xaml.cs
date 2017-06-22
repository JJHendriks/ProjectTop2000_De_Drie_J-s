using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessLayer;
using DataLayer;

namespace MockupTop2000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dgToplist.ItemsSource = Procedures.SelectListJaar(2015);
            cbYear.ItemsSource = Procedures.GetYears();
        }

        private void options_click(object sender, MouseButtonEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            window.Show();
            this.Hide();
        }

        private void cbYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dgToplist.ItemsSource = Procedures.SelectListJaar((int)cbYear.SelectedValue);
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                (dgToplist.ItemsSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dgToplist.ItemsSource as DataTable).DefaultView.RowFilter = string.Format("Name='{0}'", tbSearch.Text);
            }
        }
    }
}
