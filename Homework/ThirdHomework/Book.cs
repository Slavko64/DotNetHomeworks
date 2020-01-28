using System;
using System.Collections.Generic;

namespace ThirdHomework
{
    class Book
    {
        const int columns = 5;
        string temp = "";
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        List<string> book = new List<string>();
        List<string> editedBook = new List<string>();
        public void CreateBook()
        {
            Random rand = new Random();
            for (int i = 0; i < 1001; i++)
            {
                temp = "";
                for (int j = 0; j < 4; j++)
                    temp += alpha[rand.Next(26)];
                book.Add(temp);
            }
            Console.WriteLine(book.Count);
        }
        void RemoveDublicates()
        {
            for (int i = 0; i < book.Count; i++)
            {
                if (book.LastIndexOf(book[i]) == i)
                {
                    editedBook.Add(book[i]);
                }
                else book[i] = Convert.ToString(i);
            }

        }
        public void EditBook()
        {
            book.Sort();
            book.Reverse();
            RemoveDublicates();
            foreach (var i in book)
                if (i[0] == 'Z')
                    editedBook.Remove(i);
            Console.WriteLine(editedBook.Count);
        }
        public void DisplayPage(int PageNumber)
        {
            for (int i = PageNumber * columns, j = 0; i < editedBook.Count && j < columns; i++, j++)
                Console.WriteLine(editedBook[i]);
        }
    }
}
