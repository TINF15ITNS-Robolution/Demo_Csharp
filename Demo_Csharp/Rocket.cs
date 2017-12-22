using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Csharp
{
    class Rocket : IRocketDrawable
    {
        private Vector2D velocity, acceleration;
        private Vector2D position;
        public Image Image
        {
            get
            {
                return new Bitmap(Properties.Resources.rocket, new Size(15, 30));
            }
        }

        public Point Position
        {
            get
            {
                return position.ToPoint();
            }
        }

        public float Angle
        {
            get
            {
                return (float)((Math.Atan2(velocity.Y, -velocity.X)/ (2* Math.PI))*360);
            }
        }

        public Rocket(int x, int y)
        {
            this.position = new Vector2D(x, y);
            velocity = new Vector2D(0, 0);
            acceleration = new Vector2D(0, 0);
        }

        public void CalculateYear(Vector2D acceleration)
        {
            this.acceleration = acceleration;
            this.acceleration.Y += 0.2f;
            this.velocity += acceleration;
            this.position += velocity;
        }
    }
}
