using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ThirdHomework.Runner runner1 = new ThirdHomework.Runner();
            SecondHomeworkTask1.Runner runner2 = new SecondHomeworkTask1.Runner();
            SecondHomeworkTask2.Runner runner3 = new SecondHomeworkTask2.Runner();
            SecondHomeworkTask3.Runner runner4 = new SecondHomeworkTask3.Runner();
            SecondHomeworkTask4.Runner runner5 = new SecondHomeworkTask4.Runner();
            FirstHomework.Runner runner6 = new FirstHomework.Runner();
            runner4.Run();
        }
    }
}
