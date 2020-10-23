using System;
using System.Collections.Generic;
using System.Text;

namespace DiscStudio
{
    public abstract class Disc
    {
        string Name;
        int Capacity;
        List<string> Contents;
        string DiscType;
        bool Spinning = false;

        public Disc(string name, int capacity, List<string> contents, string discType)
        {
            Name = name;
            Capacity = capacity;
            Contents = contents;
            DiscType = discType;
        }

        public void SpinDisc()
        {
            Spinning = true;
        }

        public int CheckRemainingCapacity()
        {
            if (Capacity <= 0)
            {
                Console.WriteLine("No space left!");
                return 0;
            }
            else
            {
                Console.WriteLine("Remaining capacity: " + Capacity);
                return Capacity;
            }

        }
    }
}
