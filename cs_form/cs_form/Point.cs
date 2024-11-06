using System;

namespace cs_form
{
    internal class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static implicit operator System.Drawing.Point(Point v)
        {
            throw new NotImplementedException();
        }
    }
}