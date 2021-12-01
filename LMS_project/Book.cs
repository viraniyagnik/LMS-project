/*
 * 
 * Abstract class and Abstract method for Book
 * 
 * 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_project
{

    abstract class Book
    {
        
        /// <summary>
        /// Abstract method for books with book title, author and language.
        /// </summary>
        /// <param name="book_title">To store book title</param>
        /// <param name="author">To store book author name</param>
        /// <param name="language">To store book language</param>
        public abstract void Add_Book(string book_title, string author, string language);
       
        public string Book_Title // Book_Title property
        { get; set; } 

        public string Author // Author property
        { get; set; }

        public string Language // Language property
        { get; set; }

    }
   
   
}
