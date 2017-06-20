using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class List
    {
        private Song lied;

        public Song Lied
        {
            get { return lied; }
            set { lied = value; }
        }
        private Artist artiest;

        public Artist Artiest
        {
            get { return artiest; }
            set { artiest = value; }
        }

        private string jaar;

        public string Jaar
        {
            get { return jaar; }
            set { jaar = value; }
        }

        private string positie;

        public string Positie
        {
            get { return positie; }
            set { positie = value; }
        }

        private int verloop;

        public int Verloop
        {
            get { return verloop; }
            set { verloop = value; }
        }

        public List(Song _lied, Artist _artiest, string _jaar, string _positie, int _verloop)
        {
            this.lied = _lied;
            this.artiest = _artiest;
            this.jaar = _jaar;
            this.positie = _positie;
            this.verloop = _verloop;
        }
        public List(Song _lied, Artist _artiest, string _jaar, string _positie)
        {
            this.lied = _lied;
            this.artiest = _artiest;
            this.jaar = _jaar;
            this.positie = _positie;
       
        }
        public List(Song _lied, Artist _artiest)
        {
            this.lied = _lied;
            this.artiest = _artiest;
        }





    }
}
