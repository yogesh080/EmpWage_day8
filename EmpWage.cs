namespace EmpWage
{
    internal partial class Program
    {
        public class EmpWage
        {
            public void CheckEmp()
            {
                int PartTime = 1;
                int isFullTime = 2;
                int EmployeeWagePerHour = 20;
                int EmpDailyHour;

                Random rand = new Random();
                int Check = rand.Next(3);

                if (Check == isFullTime)
                {
                    Console.WriteLine("Employee is Present");
                    EmpDailyHour = 8;

                }
                else if(Check == PartTime)
                {
                    Console.WriteLine("Employee is Part Time");
                    EmpDailyHour=4;

                }
                else
                {
                    Console.WriteLine("Absent");
                    EmpDailyHour = 0;
                }

                int DailyWage = EmployeeWagePerHour * EmpDailyHour;
                Console.WriteLine("Per day wage of employee if Present is: " + DailyWage);

            }
        }
    }
}