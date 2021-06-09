using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsViolationRecords
{
    class Access            
        //this class holds the log in method and the main menu method im trying to separate
        //this and put this two in a different class though im still figuring out what will 
        //i do.


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


            if (user == "admin" && pass == "admin")
            {
                Console.Clear();
                menu();
               
            }

            else
            {
                Console.Clear();
                Console.Title = "PLEASE TRY AGAIN!";
                login();

            }

        }

        public void menu()
        {

          Console.Title = "Welcome to my System";

            Console.WriteLine("**************************************");
                Console.Clear();
                Console.WriteLine("            WELCOME             ");
                Console.WriteLine();
                
          Console.Write("1. Students         ");    
          Console.WriteLine("2. Violation");
          Console.WriteLine("          3. Log out");
          Console.WriteLine();
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
                        Console.Clear();
                        studentTab.addStudent();

                    Console.WriteLine("1. Add again, 2. View List, 3. Exit");
                    Console.WriteLine();
                    int studchoice = Convert.ToInt32(Console.ReadLine());

                    if (studchoice == 1)
                    {
                        Console.Clear();
                        studentTab.addStudent();
                    }
                    else if (studchoice == 2)
                    {
                        Console.Clear();
                        studentTab.studentList();
                    }
                    else if (studchoice == 3)
                    {
                        menu();
                    }
                }

                    }



                else if (choice == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("1. Violations List \n2. Add a Record\n3. Remove a Record");
                        int choice3 = Convert.ToInt32(Console.ReadLine());

                        if (choice3 == 1)
                        {
                        violationTab.viewViolationlist();
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

                else if (choice == 3)
                        {
                        Console.Clear();
                        Console.Title = "Student Violation Records";
                        
                        login();
                        }
           


            Console.ReadKey();
        }
    }
}
