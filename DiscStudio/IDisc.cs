using System;
using System.Collections.Generic;
using System.Text;

namespace DiscStudio
{
    interface IDisc
    {
        void ReadData();
        void WriteData(string dataType);
    }
}
