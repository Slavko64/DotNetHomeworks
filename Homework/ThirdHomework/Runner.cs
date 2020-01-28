using System;
namespace ThirdHomework
{
    public class Runner : IRunner
    {
        int EnterPage()
        {
            Console.Write("Please, Enter the page: ");
            string n = Console.ReadLine();
            for (int i = 0; i < n.Length; i++)
                if (char.IsDigit(n[i])== false || n[0] < '1')
                    Environment.Exit(0);
            return Convert.ToInt32(n);
        }
        public void Run()
        {
            //ExampleList example = new ExampleList();
            //example.CreatingAndAdding();
            Book b = new Book();

            b.CreateBook();
            b.EditBook();
            b.DisplayPage(EnterPage());
      
            Console.ReadLine();
        }
    }
}
