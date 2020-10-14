using System;

/* 
 * Name: Jamil Matheny & Da'Montaye Snipes
   Date: 10/14/2020
   Class: CIS214 
*/

namespace GradeBook
{
    // auto-implemented property CourseName implicity created an 
    // instance variable for this GradeBook's course name
        public class GradeBook
            {

            // Declare variables
            public string CourseName;
            public string InstructorName;
                public GradeBook (string name, string course) // declares the strings
                    {
                        // Assigns the variables to be used in the 'DisplayMessage'
                        CourseName = course; // assign the strings here
                        InstructorName = name;
                    }

                        public void DisplayMessage()
                        {
                            Console.WriteLine("Welcome to the course: " + CourseName); // outputs 'CourseName' variable 
                            Console.WriteLine("This course is presented by: " + InstructorName); // outputs 'InstructorName' variable
                        } // end method DisplayMessage

    } // end method DisplayMessage
    
} // end class GradeBook
