namespace SecondHomeworkTask2
{
    class Square : Figure
    {

        public override void Draw()
        {
           ConsolePrinter printer = new ConsolePrinter();
            printer.Print("Square");
        }
    }
}
