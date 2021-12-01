/*
 * 
 * Person class inherit to the Librarian class and Reader class. 
 * Reader class inherit to the Faculty class and Student class.
 * 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS_project
{
    /// <summary>
    /// For the person name
    /// </summary>
    /// <param name="name">for person's name</param>
    public class Person
    {
        public string name;
        public void Name()
        {
            Console.Write("Name: {0}", this.name);
        }
    }

    /// <summary>
    /// For the Librarian. 
    /// inherit person class name method.
    /// </summary>
    /// <param name="librarian_id">for librarian's id</param>
    public class Librarian : Person
    {
        public int librarian_id;
        public void librarian()
        {
            this.Name();
            Console.Write("\tLibrarian ID: {0}", this.librarian_id);
        }
    }

    /// <summary>
    /// For the Reader. 
    /// inherit person class.
    /// </summary>
    /// <param name="reader_role">for reader role</param>
    public class Reader : Person
    {
        public string reader_role;

        public void reader()
        {
            Console.Write("\tReader Role: {0}", this.reader_role);
        }
    }

    /// <summary>
    /// For the Faculty. 
    /// inherit reader class.
    /// </summary>
    /// <param name="faculty_id">for faculty id</param>
    /// <param name="subject">for the subject</param>
    public class Faculty : Reader
    {
        public int faculty_id;
        public string subject;

        public void faculty()
        {
            Console.Write("Name : {0}\tReader Role: {1}\tFaculty ID: {2}\tSubject : {3}", this.name,this.reader_role, this.faculty_id, this.subject);
        }
    }

    /// <summary>
    /// For the Student. 
    /// inherit reader class.
    /// </summary>
    /// <param name="student_id">for student id</param>
    /// <param name="semester">for the semester</param>
    /// <param name="course">for the course</param>
    public class Student : Reader
    {
        public int student_id;
        public int semester;
        public string course;

        public void student()
        {
            Console.Write("Name : {0}\tReader Role: {1}\tStudent ID: {2}\tCourse : {3} \tSemester : {4}", this.name, this.reader_role, this.student_id, this.course, this.semester);
        }
    }
}
