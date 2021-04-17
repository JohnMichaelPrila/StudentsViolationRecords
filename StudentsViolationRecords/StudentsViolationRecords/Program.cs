using System;

namespace StudentsViolationRecords
{
   
    class Student
    {
     public void studentList()
        {
            Console.WriteLine("John Michael Prila");
            Console.WriteLine("Mico Decena");
            Console.WriteLine("Royette Ringon");
            Console.WriteLine("Aeron Christ Talaro");
            Console.WriteLine("Jessie Jaradal");
        }
    public void addStudent()
        {
            Console.WriteLine("Still Working");
        }
   
    }
    class Violation
    {
        public void violationList()
        {
            Console.WriteLine("No ID");
            Console.WriteLine("Improper Uniform");
            Console.WriteLine("Cheating");
            Console.WriteLine("Gambling");
        }

        public void addRecord()
        {
            Console.WriteLine("Still Working");
        }

        public void removeRecord()
        {
            Console.WriteLine("Still Working");
        }
    }
   
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Student studentTab = new Student();
            Violation violationTab = new Violation(); 
            
            
            Console.Title = "Student Violation Records";

            
            Console.WriteLine("LOGIN");
            Console.WriteLine();
            Console.Write("Username: ");
            string user = Console.ReadLine();
            Console.Write("Password: ");
            string pass = Console.ReadLine();

           if(user == "admin" && pass == "admin")
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("WELCOME");
                Console.WriteLine();
                Console.WriteLine("Students = press 1\nViolation =press 2");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Students List = press 1\nAdd Student = press 2");
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        studentTab.studentList();
                    }
                    else if (choice2 == 2)
                    {
                        studentTab.addStudent();
                    }

                }
                
                
                
                else if (choice == 2)
                {
                    Console.WriteLine("Violations List = press 1\nAdd a Record = press 2\nRemove a Record = press 3");
                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 == 1)
                    {
                        violationTab.violationList();
                    }

                    else if (choice3 == 2)
                    {
                        violationTab.addRecord();
                    }

                    else if (choice3 == 3)
                    {
                        violationTab.removeRecord();
                    }
                }

            }
           else
            {
                Console.WriteLine("WRONG CREDENTIALS PLEASE TRY AGAIN");
            }
               

            Console.ReadKey();
        }
    }
}
