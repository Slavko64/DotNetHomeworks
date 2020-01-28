using System;

namespace SecondHomeworkTask1
{
   public class ConsolePrinter : IPrinter
    {
        public void Print(string str) => Console.WriteLine(str);
    }
}
