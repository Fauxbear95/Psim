using System;

namespace Psim
{
    namespace Geometry2D
    {
        public class Point
        {
            public double X { get; set; }  
            public double Y { get; set; }
            public Point(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }
            public void GetCoords(out double x, out double y)
            {
                x = X;
                y = Y;
            }
            public void SetCoords(double? x, double? y)
            {
                X = x ?? X;
                Y = y ?? Y;
            }
        }
        public class Vector
        {
            public double DX { get; private set; }
            public double DY { get; private set; }

            public Vector(double dx = 0, double dy = 0)
            {
                Set(dx, dy);
            }
            public void Set(double dx, double dy)
            {
                // if dx or dy <= -1 or >= 1 -> throw exception
                if (dx >= -1 && dx <= 1 && dy >= -1 && dy <= 1)
                {
                    DX = dx;
                    DY = dy;

                    return;
                }
                throw new ArgumentOutOfRangeException();
            }
            public override string ToString() => $"({DX}, {DY})";
        }
        public class Rectangle
        {
            public double Length { get; }
            public double Width { get; }
            public double Area { get; }

            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
                Area = length * width;
            }
        }
    }
}
