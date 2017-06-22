using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Lijst
    {
        private int positie;

        public int Positie
        {
            get { return positie; }
            set { positie = value; }
        }

        private string lied;

        public string Lied
        {
            get { return lied; }
            set { lied = value; }
        }
       
        private string artiest;

        public string Artiest
        {
            get { return artiest; }
            set { artiest = value; }
        }

        private int jaar;

        public int Jaar
        {
            get { return jaar; }
            set { jaar = value; }
        }

        private int verloop;

        public int Verloop
        {
            get { return verloop; }
            set { verloop = value; }
        }

        //public Lijst(string _lied, string _artiest, string _jaar, string _positie, int _verloop)
        //{
        //    this.lied = _lied;
        //    this.artiest = _artiest;
        //    this.jaar = _jaar;
        //    this.positie = _positie;
        //    this.verloop = _verloop;
        //}
        //public Lijst(string _lied, string _artiest, string _jaar, string _positie)
        //{
        //    this.lied = _lied;
        //    this.artiest = _artiest;
        //    this.jaar = _jaar;
        //    this.positie = _positie;
       
        //}
        //public Lijst(string _lied, string _artiest)
        //{
        //    this.lied = _lied;
        //    this.artiest = _artiest;
        //}

        public Lijst()
        {
            
        }





    }
}
