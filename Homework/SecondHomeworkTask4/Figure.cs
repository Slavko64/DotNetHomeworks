namespace SecondHomeworkTask4
{
    class Figure : IDrawable
    {
        readonly int x;
        readonly int y;
        public void Draw()
        {
            ConsolePrinter printer = new ConsolePrinter();
            printer.Print("Figure");
        }
        public Figure() { }
        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
