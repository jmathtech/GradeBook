using System;


/* 
 * Name: Jamil Matheny & Da'Montaye Snipes
   Date: 10/14/2020
   Class: CIS214 
*/

namespace GradeBook
{
    public class GradeBookTest
    {
        public static void Main(string[] args)
        {
            // Create a GradeBook object
            GradeBook gradeBook1 = new GradeBook("Sam Smith", "CS101 Introduction to C# Programming");
             gradeBook1.DisplayMessage(); // display welcome message

            Console.WriteLine("\nChanging instructor name to Judy Jones\n"); // changes instructor's name
            gradeBook1.InstructorName = "Judy Jones";

            gradeBook1.DisplayMessage(); // display welcome message
         


        } // end Main
    } // end class GradeBookTest
}
