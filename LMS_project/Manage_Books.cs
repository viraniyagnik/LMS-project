/*
 * 
 * Manage books.add book, remove book and show all books
 * 
 * 
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_project
{
    /// <summary>
    /// Manage the book
    /// </summary>
    public class Manage_Books<T>
    {
        public List<T> books;

        /// <summary>
        /// Manage the book
        /// </summary>
        /// <param name="books">For all book data list</param>
        public Manage_Books()
            {
                this.books = new List<T>();
            }


        /// <summary>
        /// Add the book
        /// </summary>
        /// <param name="newBook">Add the book into list</param>
        public void AddBook(T newBook)
            {
                books.Add(newBook);
            }


        /// <summary>
        /// Delete the book
        /// </summary>
        /// <param name="RemoveBook">Delete the book into list</param>
        public void DeleteBook(T RemoveBook)
            {
                books.Remove(RemoveBook);
            }


        /// <summary>
        /// Show all the book
        /// </summary>
        /// <param name="book">Show all the book from list</param>
        public void AllBooks()
            {
                foreach (var book in books)
                {
                    Console.WriteLine("Book Title : {0}\n" , book.ToString());
                }
            }
        
    }
}
