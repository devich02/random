using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rectangle : IElement
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }
        public Rectangle(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = Height;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Black, (float)X, (float)Y, (float)Width, (float)Height);
            g.DrawRectangle(Pens.Red, (float)X, (float)Y, (float)Width, (float)Height);
        }

        public List<Line> GetBorder()
        {
            return new List<Line>()
            {
                new Line { X1 = X, Y1 = Y, X2 = X + Width, Y2 = Y },
                // TODO: Fill out the rest of the lines
            };
        }

        public bool Intersects(IElement other)
        {
            throw new NotImplementedException();
        }
    }
}
