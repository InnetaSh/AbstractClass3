using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DVD: длительность(Duration).

namespace AbstractClass3
{
    internal class DVD : LibraryItem
    {
        public int Duration { get; private set; } // длительность
        public DVD(string title, string author, int duration) : base(title, author)
        {
            Duration = duration;
        }
        public override string GetInfo()
        {
            return $"DVD \'{Title}\',\nавтор - {Author},\tдлительность - {Duration}";
        }
    }
}
