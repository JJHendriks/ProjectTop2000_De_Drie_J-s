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
using BusinessLayer;

namespace MockupTop2000
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //valideer naam en ww en navigeer naar admin hub
            try
            {
                ListProvider.Inloggen(tbName.Text, tbPass.Password);
                Window window = new AdminHub();
                window.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Uw gebruikersnaam of wachtwoord is niet correct.");
                throw;
            }
        }
    }
    }
