using System;

namespace FirstHomework
{
    #region
    class Rectangle
    {
        private int LeftUpPointX, LeftUpPointY, RightDownPointX, RightDownPointY;
        public Rectangle() { }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            LeftUpX = x1;
            LeftUpY = y1;
            RightDownX = x2;
            RightDownY = y2;
        }
        public int LeftUpX
        {
            get { return LeftUpPointX; }
            set { LeftUpPointX = value; }
        }
        public int LeftUpY
        {
            get { return LeftUpPointY; }
            set { LeftUpPointY = value; }
        }
        public int RightDownX
        {
            get { return RightDownPointX; }
            set { RightDownPointX = value; }
        }
        public int RightDownY
        {
            get { return RightDownPointY; }
            set { RightDownPointY = value; }
        }
        public void Perimeter()
        {
            int per = 2 * (RightDownPointX - LeftUpPointX) + 2 * (LeftUpPointY - RightDownPointY);
            Console.WriteLine(per);
        }
        public void Area()
        {
            int S = (RightDownPointX - LeftUpPointX) * (LeftUpPointY - RightDownPointY);
            Console.WriteLine(S);
        }
    }
    #endregion
}
