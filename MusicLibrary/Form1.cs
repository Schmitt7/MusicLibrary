using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace MusicLibrary
{
    public partial class Form1 : Form
    {

        string songscontent;
        List<List<string>> SongListParts = new List<List<string>>();


        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string genre = "";

            if (rbCountry.Checked) {
                genre = "Country";
            }

            else if (rbRock.Checked)
            {
                genre = "Rock";
            }

            else if (rbPop.Checked)
            {
                genre = "Pop";
            }

            else if (rbRap.Checked)
            {
                genre = "Hip Hop / Rap";
            }


            string name = txtName.Text;
            string artist = txtArtist.Text;
            string album = txtAlbum.Text;
            string description = txtDescription.Text;
            string year = txtYear.Text;
            string length = txtLength.Text;
            string img = txtImg.Text;


            Song song1 = new Song(name, artist, genre, album, description, year, length, img);
            song1.Input();

            songscontent = song1.PrintSong();
            



            string firstsong = song1.PrintSong();
            string[] songParts = firstsong.Split(',');
            

            List<string> songList = new List<string>();
            //List<List<string>> SongListParts = new List<List<string>>();
            



            string songName = songParts[0];
            string songArtist = songParts[1];
            string songGenre = songParts[2];
            string songAlbum = songParts[3];
            string songDescription = songParts[4];
            string songYear = songParts[5];
            string songLength = songParts[6];
            string songIMG = songParts[7];

            songList.Add(songName);
            songList.Add(songArtist);
            songList.Add(songGenre);
            songList.Add(songAlbum);
            songList.Add(songDescription);
            songList.Add(songYear);
            songList.Add(songLength);
            songList.Add(songIMG);

            SongListParts.Add(songList);
            songList.Clear();
            


            //frmDisplay DisplayForm = new frmDisplay(songName, songArtist, songGenre, songAlbum, songDescription, songYear, songLength, songIMG);
            //DisplayForm.SetOwner(this);
            //DisplayForm.Show();

            //MessageBox.Show(songName + songArtist + songGenre + songAlbum + songDescription + songYear + songLength + songIMG);

            //MessageBox.Show(song1.PrintSong());
            //MessageBox.Show(song1.OutputFileContent());
            //songscontent = song1.OutputFileContent();






        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try {
                StreamWriter outputFile = File.CreateText("songs.txt");
                outputFile.Close();
            }
            catch { 
            }
            
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmDisplay DisplayForm = new frmDisplay(SongListParts);
            DisplayForm.SetOwner(this);
            DisplayForm.ShowDialog();
        }
    }
}
