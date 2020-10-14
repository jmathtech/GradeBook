using System;


/* 
 * Name: Jamil Matheny
   Date: 10/14/2020
   Class: CIS214 */
namespace GradeBook
{
    public class GradeBookTest
    {
        public static void Main(string[] args)
        {
            // Create a GradeBook object
            GradeBook gradeBook1 = new GradeBook( // invokes constructor
                "CS101 Introduction to C# Programming" );
            GradeBook gradeBook2 = new GradeBook( // invokes constructor
                "CS102 Data Structures in C#");

            // display initial value of CourseName
            Console.WriteLine("gradeBook1 course name is: {0}", gradeBook1.CourseName);
            Console.WriteLine("gradeBook2 course name is: {0}", gradeBook2.CourseName);

        } // end Main
    } // end class GradeBookTest
}
