using System;
using System.Collections.Generic;

namespace StudentsViolationRecords
{
   
   
    class Program// this class holds the main method.
    {
     

        static void Main(string[] args)
        {




            Access menuu = new Access();

            Console.Title = "Student Violation Records";

            menuu.login();

            Console.ReadLine();
        }

      
    }
    
}
