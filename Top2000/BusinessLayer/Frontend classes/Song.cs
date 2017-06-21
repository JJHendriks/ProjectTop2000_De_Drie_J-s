using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Song
    {
        private string song_ID;

        public string Song_ID 
        {
            get { return song_ID; }
            set { song_ID = value; }
        }

        private string artist_ID;

        public string Artist_ID
        {
            get { return artist_ID; }
            set { artist_ID = value; }
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

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private string extra_Info;

        public string Extra_Info
        {
            get { return extra_Info; }
            set { extra_Info = value; }
        }



        public Song(string songid, string artist_id, string title, string year, string image, string extrainfo)
        {
            this.song_ID = songid;
            this.artist_ID = artist_id;
            this.title = title;
            this.year = year;
            this.image = image;
            this.extra_Info = extrainfo;
        }

        public Song()
        {
            
        }


    }
}
