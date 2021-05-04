using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsViolationRecords
{
class Student
    {
        
        public List<String> studList = new List<string> {"CURRENT LIST"};
        
        
        
        
        public void studentList()//View Students List 
        {

            

        }

        public void addStudent()// Add Student in the list
        {

            Console.WriteLine("Enter Student Name: ");
            studList.Add(Console.ReadLine());
            

            Console.WriteLine("Student Added Succefully!");
            studList.ForEach(Console.WriteLine);

            Console.WriteLine("Would you like to Add again? =1, EXIT= 2");
            int studchoice = Convert.ToInt32(Console.ReadLine());

            if (studchoice == 1)
            {
                Console.Clear();
                addStudent();
            }
            else if (studchoice == 2)
            {
                  
            }



            


        }

    }
}
