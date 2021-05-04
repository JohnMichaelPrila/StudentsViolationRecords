using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsViolationRecords
{
    class mainMenuu
    {
        Student studentTab = new Student();
        Violation violationTab = new Violation();
        public string user;
        public string pass;


        public void login()
        {
            Console.WriteLine("         LOGIN         ");
            Console.WriteLine();
            Console.Write("Username: ");
            user = Console.ReadLine();
            Console.Write("Password: ");
            pass = Console.ReadLine();
        }

        public void menu()
        {
            

                Console.WriteLine("**************************************");
                Console.Clear();
                Console.WriteLine("                WELCOME               ");
                Console.WriteLine();
                Console.WriteLine("1. Students\n2. Violation");
                Console.Write("Action: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Clear();

                    Console.WriteLine("1. Students List \n2. Add Student");
                    Console.Write("Action: ");

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
                    Console.Clear();

                    Console.WriteLine("1. Violations List \n2. Add a Record\n3. Remove a Record");
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

            
           


            Console.ReadKey();
        }
    }
}
