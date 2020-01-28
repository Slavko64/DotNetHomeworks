using System;

namespace SecondHomeworkTask4
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string str) => Console.WriteLine(str);
    }
}
