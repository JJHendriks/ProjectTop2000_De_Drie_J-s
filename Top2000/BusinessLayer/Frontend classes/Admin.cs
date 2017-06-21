using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    /// <summary>
    /// Een admin die de quiz kan aanpassen
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// Veld voor de gebruikersnaam van de admin
        /// </summary>
        private string gebruikersnaam;
        /// <summary>
        /// Property voor de gebruikersnaam van de Admin
        /// </summary>
        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }
        /// <summary>
        /// Veld voor het wachtwoord van de admin
        /// </summary>
        private string wachtwoord;
        /// <summary>
        /// Property voor het wachtwoord van de admin
        /// </summary>
        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        public Admin(string _gebruikersnaam, string _wachtwoord)
        {
            gebruikersnaam = _gebruikersnaam;
            wachtwoord = _wachtwoord;
        }

        public override string ToString()
        {
            return string.Format("Welkom, {0}!", gebruikersnaam);
        }
    }
}
