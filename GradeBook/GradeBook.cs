using System;

/* 
 * Name: Jamil Matheny
   Date: 10/14/2020
   Class: CIS214 */

namespace GradeBook
{
    public class GradeBook
    {
        // auto-implemented property CourseName implicity created an 
        // instance variable for this GradeBook's course name
        public string CourseName { get; set; }

        // constructor initializes auto-implemented property
        // CourseName with string supplied as argument
        public GradeBook (string name)
        {
            CourseName = name; // set CourseName to name
        } // end Constructor

        public void DisplayMessage()
        {
            // use auto-implemented property CourseName to get the name of the course 
            // that this GradeBook represents
            Console.WriteLine("Welcome to the grade book for\n{0}!", CourseName);

        } // end method DisplayMessage
    } // end class GradeBook
} // end namespace
