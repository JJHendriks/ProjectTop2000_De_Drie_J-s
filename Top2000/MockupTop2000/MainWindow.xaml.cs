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

            //Vult de combobox met een lijst van beschikbare jaren
            foreach (var item in Procedures.GetYears())
            {
                cbYear.Items.Add(item.Jaar);
            }
        }

        private void options_click(object sender, MouseButtonEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            window.Show();
            this.Hide();
        }

        private void cbYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Refresht de datagrid om het gekozen jaar te tonen
            dgToplist.ItemsSource = Procedures.SelectListJaar((int)cbYear.SelectedValue);
        }


        //Methode voor het zoeken naar een song in de datagrid
        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filterText = tbSearch.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dgToplist.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {
                cv.Filter = o =>
                {
                    Lijst p = o as Lijst;
                    //Als een lied de filter tekens bevat wordt hij getoont.
                    return (p.Lied.ToUpper().Contains(filterText.ToUpper()));
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
