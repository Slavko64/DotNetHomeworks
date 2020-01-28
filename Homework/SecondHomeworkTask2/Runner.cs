using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeworkTask2
{
    public class Runner
    {
        public void Run()
        {
            Square s = new Square();
            Rectangle r = new Rectangle();
            s.Draw();
            r.Draw();
            System.Console.ReadLine();
        }
    }
}
