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

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private int artist_id;

        public int Artist_id
        {
            get { return artist_id; }
            set { artist_id = value; }
        }

        private string artist_Name;

        public string Artist_name
        {
            get { return artist_Name; }
            set { artist_Name = value; }
        }

        public Song(int songid, int artist_Id, string artist_name, string title, int year)
        {
            this.song_ID = songid;
            this.artist_id = artist_Id;
            this.artist_Name = artist_name;
            this.title = title;
            this.year = year;
        }

        public Song()
        {
            
        }


    }
}
