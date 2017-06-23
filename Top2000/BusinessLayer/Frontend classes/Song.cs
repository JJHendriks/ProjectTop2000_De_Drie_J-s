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

        private string songtext;

        public string Songtext
        {
            get { return songtext; }
            set { songtext = value; }
        }



        public Song(int songid, string artist_name, string title, string year, string text)
        {
            this.song_ID = songid;
            this.artist_Name = artist_name;
            this.title = title;
            this.year = year;
            this.songtext = text;
        }

        public Song()
        {
            
        }


    }
}
