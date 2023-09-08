﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_Square_End.Logic
{
    public class Square : Rectangle
    {
        public new int Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public new int Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public Square(int length) : base(length, length)
        {
        }
    }
}
