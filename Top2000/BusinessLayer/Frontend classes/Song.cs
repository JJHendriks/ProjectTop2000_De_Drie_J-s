using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Song
    {
        private int song_ID;

        public int Song_ID 
        {
            get { return song_ID; }
            set { song_ID = value; }
        }

        private string artist_Name;

        public string Artist_name
        {
            get { return artist_Name; }
            set { Artist_name = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        private string extra_Info;

        public string Extra_Info
        {
            get { return extra_Info; }
            set { extra_Info = value; }
        }



        public Song(int songid, string artist_name, string title, string year, string extrainfo)
        {
            this.song_ID = songid;
            this.artist_Name = artist_name;
            this.title = title;
            this.year = year;
            this.extra_Info = extrainfo;
        }

        public Song()
        {
            
        }


    }
}
