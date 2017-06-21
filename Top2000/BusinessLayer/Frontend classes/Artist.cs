using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Artist
    {
        private string artist_ID;

        public string Artist_ID
        {
            get { return artist_ID; }
            set { artist_ID = value; }
        }
        private string artist_Name;

        public string Artist_Name 
        {
            get { return artist_Name; }
            set { artist_Name = value; }
        }

        private string extra_Info;

        public string Extra_Info
        {
            get { return extra_Info; }
            set { extra_Info = value; }
        }



    }
}
