﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSamples.Square
{
    class Square : Rectangle
    {
        public override double Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
