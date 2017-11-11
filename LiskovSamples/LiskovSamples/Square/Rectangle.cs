using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSamples.Square
{
    public class Rectangle
    {
        public virtual Double Width { get; set; }

        public virtual Double Height { get; set; }


        public Double Area => Width * Height;
    }
}
