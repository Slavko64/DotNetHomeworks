using System;

namespace SecondHomeworkTask2
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string str) => Console.WriteLine(str);
    }
}
