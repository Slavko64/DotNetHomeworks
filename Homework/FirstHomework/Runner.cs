using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    public class Runner
    {
        public void Run()
        {
            int LeftUpPointX;
            int LeftUpPointY;
            int RightDownPointX;
            int RightDownPointY;
            double R = 5;
            LeftUpPointX = Convert.ToInt32(Console.ReadLine());
            LeftUpPointY = Convert.ToInt32(Console.ReadLine());
            RightDownPointX = Convert.ToInt32(Console.ReadLine());
            RightDownPointY = Convert.ToInt32(Console.ReadLine());
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------1");
            Rectangle R1 = new Rectangle(LeftUpPointX, LeftUpPointY, RightDownPointX, RightDownPointY);
            R1.Perimeter();
            R1.Area();
            Console.WriteLine("-----------------------2");
            Rectangle R2 = new Rectangle();
            R2.LeftUpX = LeftUpPointX;
            R2.LeftUpY = LeftUpPointY;
            R2.RightDownX = RightDownPointX;
            R2.RightDownY = RightDownPointY;
            R2.Perimeter();
            R2.Area();
            Console.WriteLine("----------------------3");
            Circle C1 = new Circle();
            C1.Area(R);
            C1.Length(R);
            Console.WriteLine("----------------------4");
            Rectangle1.Perimeter(LeftUpPointX, LeftUpPointY, RightDownPointX, RightDownPointY);
            Rectangle1.Area(LeftUpPointX, LeftUpPointY, RightDownPointX, RightDownPointY);
            Circle1.Length(R);
            Circle1.Area(R);
            ComplexNumber c1 = new ComplexNumber { Number = Console.ReadLine() };
            ComplexNumber c2 = new ComplexNumber { Number = Console.ReadLine() };
            ComplexNumber c3 = c1 * c2;
            ComplexNumber c4 = c1 / c2;
            Console.WriteLine(c3.Number + "\n" + c4.Number);

            Console.ReadLine();
        }
    }
}
