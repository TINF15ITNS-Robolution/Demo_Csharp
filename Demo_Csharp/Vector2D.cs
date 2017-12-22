﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Csharp
{
    class Vector2D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector2D(float x, float y)
        {
            X = x;
            Y = y;
        }
        public static Vector2D operator+ (Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }

        public Point ToPoint()
        {
            return new Point((int)this.X, (int)this.Y);
        }
    }
}
