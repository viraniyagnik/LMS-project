/*
 * 
 * For History books.
 * 
 * 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_project
{
    class History_Books : Book
    {
        /// <summary>
        /// Add the history books with book title, author and language.
        /// </summary>
        /// <param name="book_title">To store book title</param>
        /// <param name="author">To store book author name</param>
        /// <param name="language">To store book language</param>
        public void History_book()
        {
            Console.WriteLine("******************History books******************");
        }
        public override void Add_Book(string book_title, string author, string language)
        {
            Book_Title = book_title;
            Author = author;
            Language = language;
            Console.WriteLine("Book Title : {0}\nBook Author : {1}\nIn {2} language\n-----------------------------------------------------", Book_Title, Author, Language);

        }
       
    }
}
