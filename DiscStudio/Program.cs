 using System;
using System.Collections.Generic;

namespace DiscStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> songList = new List<string>();
            songList.Add("Song A");
            songList.Add("Song B");

            List<string> movieList = new List<string>();
            movieList.Add("Return of the King");

            CD myFirstCD = new CD("Meteora", 10, songList, "cd");
            DVD myFirstDVD = new DVD("Lord of the Rings", 20, movieList, "dvd");

            myFirstCD.CheckRemainingCapacity();

            myFirstDVD.SpinDisc();

            myFirstCD.ReadData();
            myFirstDVD.WriteData("The Two Towers");
        }
    }
}
