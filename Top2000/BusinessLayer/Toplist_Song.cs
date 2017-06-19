using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Toplist_Song
    {
        private string toplist_Year;

        public string Toplist_Year
        {
            get { return toplist_Year; }
            set { toplist_Year = value; }
        }

        private string song_ID;

        public string Song_ID
        {
            get { return song_ID; }
            set { song_ID = value; }
        }

        private int rank;

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }



    }
}
