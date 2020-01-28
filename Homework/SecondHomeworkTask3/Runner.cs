using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeworkTask3
{
    public class Runner
    {
        public void Run()
        {
            Square s = new Square();
            Rectangle r = new Rectangle();
            Figure f = new Figure();
            s.Draw();
            r.Draw();
            f.Draw();
            System.Console.ReadLine();
        }
    }
}
