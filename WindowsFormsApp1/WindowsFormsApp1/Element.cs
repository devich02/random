using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IElement
    {
        void Draw(Graphics g);
        List<Line> GetBorder();
        bool Intersects(IElement other);
    }
}
