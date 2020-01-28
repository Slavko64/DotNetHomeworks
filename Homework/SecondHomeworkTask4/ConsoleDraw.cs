namespace SecondHomeworkTask4
{
    class ConsoleDraw
    {
        static public void DrawAll(params IDrawable[] array)
        {
            foreach (IDrawable i in array)
                i.Draw();
        }
    }
}
