using System;
using System.Collections.Generic;

namespace StudentsViolationRecords
{
   
   
    class Program
    {
        
        
        static void Main(string[] args)
        {

            mainMenuu menuu = new mainMenuu();
            
            Console.Title = "Student Violation Records";

            menuu.login();

            if (menuu.user == "admin" && menuu.pass == "admin")
            {
                Console.Clear();
                menuu.menu();
            }
            else
            {
                Console.WriteLine("WRONG CREDENTIALS PLEASE TRY AGAIN");
            }





        }
    }
    
}
