/*
 * 
 * Library management system.
 * 
 * 
*/
using System;
using LMS_project;

namespace LMS_project
{
    class program
    {
        static void Main(string[] args)
        {
            //To add study books
            Study_Books study = new Study_Books();
            study.Study_book();
            study.Add_Book("Maths", "Kjartan Poskitt", Language.English.ToString());
            study.Add_Book("Head First Java", "Kathy Sierra", Language.French.ToString());
            study.Add_Book("Learning C# Programming with Unity 3D", "Alex Okita", Language.Hindi.ToString());
            study.Add_Book("C# in Depth", "Jon Skeet", Language.French.ToString());



            // To add History books
            History_Books history = new History_Books();
            history.History_book();
            history.Add_Book("Grant", "Ron Chernow", Language.French.ToString());          
            history.Add_Book("The History of the Ancient World", "Susan Wise Bauer", Language.Hindi.ToString());          
            history.Add_Book("Democracy: A Life", "Paul Cartledge", Language.Hindi.ToString());
            history.Add_Book("Frederick Douglas: Prophet of Freedom", "David W. Blight", Language.English.ToString());


            // To add Extra Curricular Book
            Extra_Curricular_Book extra_Curricular = new Extra_Curricular_Book();
            extra_Curricular.Extra_Curricular_book();
            extra_Curricular.Add_Book("A Pedagogy of Place", "Brian Wattchow", Language.French.ToString());
            extra_Curricular.Add_Book("Mini-Masterpieces", "Laura Loahmann", Language.Hindi.ToString());
            extra_Curricular.Add_Book("The playHOORAY! Handbook", "Claire Russell", Language.Hindi.ToString());
            extra_Curricular.Add_Book("Critical Thinking", "Jonathan Haber", Language.English.ToString());

            // For person details
            Console.WriteLine("\nPerson Details");
            Librarian lib = new Librarian();
            lib.name = "Virani";
            lib.librarian_id = 101 ;
            lib.librarian();
            Console.WriteLine("\n");

            //For the faculty 
            Faculty Fac = new Faculty();
            Fac.name = "Yagnik";
            Fac.reader_role = "Faculty";
            Fac.faculty_id = 001;
            Fac.subject = "C#";
            Fac.faculty();
            Console.WriteLine("\n");

            //For the student
            Student Stu = new Student();
            Stu.name = "John";
            Stu.reader_role = "Student";
            Stu.student_id = 201;
            Stu.course = "CPIN";
            Stu.semester = 3;
            Stu.student();
            Console.WriteLine("\n");

            //Manage books data add, delete and show.
            Manage_Books<string> Books = new Manage_Books<string>();
            Books.AddBook("Maths");
            Books.AddBook("c#");
            Books.AddBook("Java");
            Books.AddBook("The History");
            Books.DeleteBook("c#");

            Books.AllBooks();
        }
    }
}
