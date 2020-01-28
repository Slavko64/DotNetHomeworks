namespace SecondHomeworkTask4
{
    class Square : IDrawable
    {

        public void Draw()
        {
            ConsolePrinter printer = new ConsolePrinter();
            printer.Print("Square");
        }
    }
}
