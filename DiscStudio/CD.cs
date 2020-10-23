using System;
using System.Collections.Generic;
using System.Text;

namespace DiscStudio
{
    public class CD : Disc, IDisc
    {
        public CD(string name, int capacity, List<string> contents, string discType) : base(name, capacity, contents, discType)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Playing songs: ");
            // foreach(string song in Contents)
        }

        public void WriteData(string song)
        {
            Console.WriteLine("Adding song: ");
            // Contents.Add(song);
        }
    }
}
