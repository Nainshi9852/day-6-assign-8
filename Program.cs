using System;

namespace SalaryCalculationSystem
{
     
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary Calculation System!");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");

            int employeeType = int.Parse(Console.ReadLine());

            double monthlySalary;

            switch (employeeType)
            {
                case 1: // HR
                    Console.Write("Enter working hours: ");
                    int hrWorkingHours = int.Parse(Console.ReadLine());

                    Console.Write("Enter number of working days: ");
                    int hrNumOfWorkingDays = int.Parse(Console.ReadLine());

                    monthlySalary = CalculateMonthlySalary(hrWorkingHours, hrNumOfWorkingDays, projectHandles: 1, extras: 0);
                    break;

                case 2: // Admin
                    Console.Write("Enter working hours: ");
                    int adminWorkingHours = int.Parse(Console.ReadLine());

                    Console.Write("Enter number of working days: ");
                    int adminNumOfWorkingDays = int.Parse(Console.ReadLine());

                    Console.Write("Enter number of project handles: ");
                    int projectHandles = int.Parse(Console.ReadLine());

                    monthlySalary = CalculateMonthlySalary(adminWorkingHours, adminNumOfWorkingDays, projectHandles, extras: 0);
                    break;

                case 3: // Software Developer
                    Console.Write("Enter working hours: ");
                    int devWorkingHours = int.Parse(Console.ReadLine());

                    Console.Write("Enter number of working days: ");
                    int devNumOfWorkingDays = int.Parse(Console.ReadLine());

                    Console.Write("Enter number of project handles: ");
                    int devProjectHandles = int.Parse(Console.ReadLine());

                    Console.Write("Enter extras: ");
                    int extras = int.Parse(Console.ReadLine());

                    monthlySalary = CalculateMonthlySalary(devWorkingHours, devNumOfWorkingDays, devProjectHandles, extras);
                    break;

                default:
                    Console.WriteLine("Invalid employee type selected.");
                    return;
            }

            Console.WriteLine($"Monthly Salary: {monthlySalary}");
            Console.ReadKey();
        }
        static double CalculateMonthlySalary(int workingHours, int numOfWorkingDays, int projectHandles, int extras)
        {
         
            double sal = workingHours * numOfWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
            return sal;
        }


    }
}