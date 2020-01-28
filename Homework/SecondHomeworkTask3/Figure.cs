namespace SecondHomeworkTask3
{
    class Figure
    {
        readonly int x;
        readonly int y;
        public virtual void Draw()
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
