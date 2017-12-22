using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Csharp
{
    public interface IRocketDrawable
    {
        Image Image { get; }
        float Angle { get; }
        Point Position { get; }
    }
}
