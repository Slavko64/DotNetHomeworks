namespace SecondHomeworkTask2
{
    abstract class Figure
    {
        readonly int x;
        readonly int y;
        public abstract void Draw();
        public Figure() { }
        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
