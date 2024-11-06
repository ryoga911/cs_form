using System;

namespace cs_form
{
    internal class Size
    {
        private int width;
        private int height;

        public Size(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public static implicit operator System.Drawing.Size(Size v)
        {
            throw new NotImplementedException();
        }
    }
}