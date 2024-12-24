using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Check
{
    internal class Employee
    {
        public static void Main(string[] args)
        {
            bool IsPresent=EmployeeAttendence();
            DailyWages(IsPresent);
            



            Console.WriteLine("1.Employee attendence");
            Console.WriteLine("2.Daily wages");
            Console.Write("Enter your choice ");
            Console.WriteLine( );

             List<Employee> list = new List<Employee>();
            list.Add(new Employee());
            Console.WriteLine( "wage of part time employee is :"+(8*20));
            

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EmployeeAttendence();
                    break;
                case 2:
                    DailyWages(IsPresent);
                    break;
                
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
        public static bool EmployeeAttendence()
        {
            Random random = new Random();
            int rd = random.Next(0, 2);
            Console.WriteLine("the random function returned:"+rd);

            if (rd == 1)
            {
                Console.WriteLine("Employee is present");
                return true;
            }
       
            else
            {
                Console.WriteLine("Employee is absent");
                return false;
            }
       
        }
        public static void DailyWages(bool IsPresent)
        {
            if(IsPresent)
            {

             
                int DWages= 8 * 20;
                Console.WriteLine("daily wages of an employee is: "+DWages);
                Console.WriteLine("enter number of days as 20");

                int days=int.Parse(Console.ReadLine());
                Console.WriteLine("enter number of hours as 8");

                int hours=int.Parse(Console.ReadLine());
                Console.WriteLine("monthly wages of an employee is: " + days*hours*20);
                if (days==20 || hours == 100)
                {

                    Console.WriteLine(hours * 20);
                    Console.WriteLine(20 * 100);
                }

            }
        }
    }
}
