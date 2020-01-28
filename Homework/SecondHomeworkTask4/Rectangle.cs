namespace SecondHomeworkTask4
{
    class Rectangle : IDrawable
    {
        public void Draw()
        {
            ConsolePrinter printer = new ConsolePrinter();
            printer.Print("Reatangle");
        }
    }
}
