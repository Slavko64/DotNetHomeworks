using System;

namespace FirstHomework
{
    #region
    #endregion
    #region
    static class Rectangle1
    {
        public static void Perimeter(int LeftUpPointX, int LeftUpPointY, int RightDownPointX, int RightDownPointY)
        {
            int per = 2 * (RightDownPointX - LeftUpPointX) + 2 * (LeftUpPointY - RightDownPointY);
            Console.WriteLine(per);
        }
        public static void Area(int LeftUpPointX, int LeftUpPointY, int RightDownPointX, int RightDownPointY)
        {
            int S = (RightDownPointX - LeftUpPointX) * (LeftUpPointY - RightDownPointY);
            Console.WriteLine(S);
        }
    }
    #endregion
}
