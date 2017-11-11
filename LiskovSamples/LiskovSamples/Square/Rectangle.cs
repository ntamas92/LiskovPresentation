using System;

namespace LiskovSamples.Square
{
    public class Rectangle
    {
        public virtual Double Width { get; set; }

        public virtual Double Height { get; set; }


        public Double Area => Width * Height;
    }
}
