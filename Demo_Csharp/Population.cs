using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Csharp
{
    class Population
    {
        public Rocket[] rockets;
        int lifetime = 200;
        public Population()
        {
            rockets = new Rocket[1];
            rockets[0] = new Rocket(200, 200);
        }
        public void CalculateYear()
        {
            foreach(Rocket rocket in rockets)
            {
                rocket.CalculateYear(new Vector2D(0.3f,0));
            }
        }
    }
}
