using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace MusicLibrary
{
    public class Song
    {
        private string name;
        private string artist;
        private string genre;
        private string album;
        private string description;
        private string year;
        private string length;
        private string img;

        


        public Song() { }


        public Song(string name, string artist, string genre, string album, string description,
                        string year, string length, string img)
        {
            this.name = name;
            this.artist = artist;
            this.genre = genre;
            this.album = album;
            this.description = description;
            this.year = year;
            this.length = length;
            this.img = img;
        }

        public string GetName() {
            return name;
        }

        public string GetArtist() {
            return artist;
        }

        public string GetGenre() {
            return genre;
        }

        public string GetAlbum() {
            return album;
        }

        public string GetDescription() {
            return description;
        }

        public string GetYear() {
            return year;
        }

        public string GetLength() {
            return length;
        }

        public string GetImg() {
            return img;
        }

        //private string name;
        //private string artist;
        //private string genre;
        //private string album;
        //private string description;
        //private int year;
        //private int length;
        //private string img;

        public void SetName(string value) {
            name = value;
        }

        public void SetArtist(string value) {
            artist = value;
        }

        public void SetGenre(string value) {
            genre = value;
        }

        public void SetAlbum(string value) {
            album = value;
        }

        public void SetDescription(string value) {
            description = value;
        }

        public void SetYear(string value) {
            year = value;
        }

        public void SetLength(string value) {
            length = value;
        }

        public void SetImg(string value) {
            img = value;
        }


        public string PrintSong()
        {

            string Songprinting = GetName() + "," 
                                + GetArtist() + "," 
                                + GetGenre() + "," 
                                + GetAlbum() + ","
                                + GetDescription() + ","
                                + GetYear() + ","
                                + GetLength() + ","
                                + GetImg();


            return Songprinting;
        }

        public void Input() {


            try {
                string SongList = GetName() + ", " + GetArtist() + ", " +
                                    GetGenre() + ", " + GetAlbum() + ", " +
                                    GetDescription() + ", " + GetYear() + ", " +
                                    GetLength() + ", " + GetImg();
                
                StreamWriter outputFile = File.AppendText("songs.txt");
                outputFile.WriteLine(SongList);
                outputFile.Close();
            }
            catch { 
            }
            

            
        }

        public string OutputFileContent() {

            string songlist;
            songlist = File.ReadAllText("songs.txt");

            return songlist;
        }

        


    }


    

    
}
