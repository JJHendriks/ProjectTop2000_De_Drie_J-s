using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public static class ListProvider
    {





        public static List<Admin> Admins;
        /// <summary>
        /// Deze methode maakt alle admins aan
        /// </summary>
        public static void LijstAdminsVullen()
        {
            if (Admins == null)
            {
                Admins = new List<Admin>();


                Admins.Add(new Admin
                    (
                    _gebruikersnaam: "jimhendriks",
                    _wachtwoord: "wachtwoord"
                    ));

                Admins.Add(new Admin
                    (
                    _gebruikersnaam: "gebruiker",
                    _wachtwoord: "wachtwoord"
                    ));

                Admins.Add(new Admin
                    (
                    _gebruikersnaam: "gebruiker2",
                    _wachtwoord: "wachtwoord2"
                    ));

            }

        }
        /// <summary>
        /// Deze methode haalt een admin uit de lijst doormiddel van de gebruikersnaam en het wachtwoord
        /// </summary>
        /// <param name="_gebruikersnaam"></param>
        /// <param name="_wachtwoord"></param>
        /// <returns></returns>
        public static Admin Inloggen(string _gebruikersnaam, string _wachtwoord)
        {
            LijstAdminsVullen();
            var list = Admins;

            foreach (var item in list)
            {
                if (_gebruikersnaam == item.Gebruikersnaam)
                {
                    if (_wachtwoord == item.Wachtwoord)
                    {
                        return item;
                    }
                    else
                    {
                        throw new ArgumentException("Uw wachtwoord klopt niet");
                    }
                }

            }
            throw new ArgumentException("Uw gebruikersnaam bestaat niet");


        }
    }
}

