using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeworkTask4
{
    public class Runner
    {
        public void Run()
        {
            Square s1 = new Square();

            Figure f1 = new Figure(1, 0);
            Figure f2 = new Figure();
            Rectangle r1 = new Rectangle();
            IDrawable[] d1 = { s1, f1, f2, r1 };
            ConsoleDraw.DrawAll(d1);
            Console.ReadLine();
        }
    }
}
