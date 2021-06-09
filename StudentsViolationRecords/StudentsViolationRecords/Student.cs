using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsViolationRecords
{
 class Student
        //like the violation class this class processes everything
        //related in students and ill also separate each method here
    {

        


        public List<String> studList = new List<string> {"CURRENT LIST"};

        string Studname;
        string Studnum;
        string YearandSection;
        

        
       
  
        
        
        public void studentList()//View Students List 
        {
            
                
            Console.WriteLine("CURRENT LIST");
            Console.WriteLine();
            Console.Write(Studname);
            Console.Write(Studname);




        }

        public void addStudent()// Add Student in the list
        {
            Console.WriteLine();
            Console.WriteLine("Enter Student Name:(Surname, First name, Middle Initial) ");
            studList.Add(Studname= Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Student ID: ");
            studList.Add(Studnum = Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Year and Section ");
            studList.Add(YearandSection = Console.ReadLine());




            Console.Clear();
            Console.WriteLine("Student Added Succefully!");
            //studList.ForEach(Console.WriteLine);


        }

    }
}
