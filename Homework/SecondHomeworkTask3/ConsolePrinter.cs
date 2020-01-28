using System;

namespace SecondHomeworkTask3
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string str) => Console.WriteLine(str);
    }
}
