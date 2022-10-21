using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class frmDisplay : Form
    {
        string songtext;
        string testpassSong;
        string[] songdata;
        List<List<string>> SongListParts;

        string songName;
        string songArtist;
        string songGenre;
        string songAlbum;
        string songDescription;
        string songYear;
        string songLength;
        string songIMG;

        public Form1 ownerForm;

        public void SetOwner(Form theForm) {
            ownerForm = (Form1)theForm;
        }
        public frmDisplay()
        {
            InitializeComponent();
        }

        public frmDisplay(string[] songdata)
        {
            InitializeComponent();
            this.songdata = songdata;
        }

        public frmDisplay(List<List<string>> SongListParts)
        {
            InitializeComponent();
            this.SongListParts = SongListParts;
        }

        public frmDisplay(string songtext)
        {
            InitializeComponent();
            this.songtext = songtext;
        }

        public frmDisplay(string songName, string songArtist, string songGenre, string songAlbum, string songDescription, string songYear, string songLength, string songIMG) {
            InitializeComponent();
            this.songName = songName;
            this.songArtist = songArtist;
            this.songGenre = songGenre;
            this.songAlbum = songAlbum;
            this.songDescription = songDescription;
            this.songYear = songYear;
            this.songLength = songLength;
            this.songIMG = songIMG;
        }

        

        public void frmDisplay_Load(object sender, EventArgs e)
        {
            lvMusic.View = View.Details;
            lvMusic.Columns.Add("Song Name");
            lvMusic.Columns.Add("Artist");
            lvMusic.Columns.Add("Genre");
            lvMusic.Columns.Add("Album");
            lvMusic.Columns.Add("Description");
            lvMusic.Columns.Add("Year Released");
            lvMusic.Columns.Add("Length");
            lvMusic.Columns.Add("IMG Url");


            


            System.IO.StreamReader streamRead = new System.IO.StreamReader("songs.txt");
            int counter = 0;
            while (!streamRead.EndOfStream)
            {
                
                string indSong = streamRead.ReadLine();
                songdata = indSong.Split(',');
                lvMusic.Items.Add(songdata[0]);
                lvMusic.Items[counter].SubItems.Add(songdata[1]);
                lvMusic.Items[counter].SubItems.Add(songdata[2]);
                lvMusic.Items[counter].SubItems.Add(songdata[3]);
                lvMusic.Items[counter].SubItems.Add(songdata[4]);
                lvMusic.Items[counter].SubItems.Add(songdata[5]);
                lvMusic.Items[counter].SubItems.Add(songdata[6]);
                lvMusic.Items[counter].SubItems.Add(songdata[7]);
                counter++;
            }
            streamRead.Close();


            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string genreSelect = txtGenre.Text.ToLower();

            string artistSelect = txtBand.Text.ToLower();

            string songSelect = txtName.Text.ToLower();


            if (genreSelect != "") {
                for (int i = lvMusic.Items.Count - 1; -1 < i; i--)
                {
                    if (lvMusic.Items[i].SubItems[2].Text.ToLower().Contains(genreSelect) != true)
                    {
                        lvMusic.Items[i].Remove();
                    }
                }
            }

            if (artistSelect != "") {
                for (int i = lvMusic.Items.Count - 1; -1 < i; i--)
                {
                    if (lvMusic.Items[i].SubItems[1].Text.ToLower().Contains(artistSelect) != true)
                    {
                        lvMusic.Items[i].Remove();
                    }
                }
            }

            for (int i = lvMusic.Items.Count - 1; -1 < i; i--)
            {
                if (lvMusic.Items[i].Text.ToLower().Contains(songSelect) != true)
                {
                    lvMusic.Items[i].Remove();
                }
            }


        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

            lvMusic.Clear();
            lvMusic.View = View.Details;
            lvMusic.Columns.Add("Song Name");
            lvMusic.Columns.Add("Artist");
            lvMusic.Columns.Add("Genre");
            lvMusic.Columns.Add("Album");
            lvMusic.Columns.Add("Description");
            lvMusic.Columns.Add("Year Released");
            lvMusic.Columns.Add("Length");
            lvMusic.Columns.Add("IMG Url");


            System.IO.StreamReader streamRead = new System.IO.StreamReader("songs.txt");
            int counter = 0;
            while (!streamRead.EndOfStream)
            {

                string indSong = streamRead.ReadLine();
                songdata = indSong.Split(',');
                lvMusic.Items.Add(songdata[0]);
                lvMusic.Items[counter].SubItems.Add(songdata[1]);
                lvMusic.Items[counter].SubItems.Add(songdata[2]);
                lvMusic.Items[counter].SubItems.Add(songdata[3]);
                lvMusic.Items[counter].SubItems.Add(songdata[4]);
                lvMusic.Items[counter].SubItems.Add(songdata[5]);
                lvMusic.Items[counter].SubItems.Add(songdata[6]);
                lvMusic.Items[counter].SubItems.Add(songdata[7]);
                counter++;
            }
            streamRead.Close();

        }
    }
}
