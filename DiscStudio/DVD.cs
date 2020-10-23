using System;
using System.Collections.Generic;
using System.Text;

namespace DiscStudio
{
    public class DVD : Disc, IDisc
    {
        public DVD(string name, int capacity, List<string> contents, string discType) : base(name, capacity, contents, discType)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Playing movie: ");
            // foreach(string movie in Contents)
        }

        public void WriteData(string movie)
        {
            Console.WriteLine("Adding movie: ");
            //Contents.Add(movie)
        }
    }
}
