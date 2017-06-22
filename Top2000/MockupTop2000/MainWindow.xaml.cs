using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string filterText = tbSearch.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dgToplist.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o => {
                    /* change to get data row value */
                    Lijst p = o as Lijst;
                    return (p.Artiest.ToUpper().StartsWith(filterText.ToUpper()));
                    /* end change to get data row value */
                };
            }
        }
    }
}
