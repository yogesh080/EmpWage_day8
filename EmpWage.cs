namespace EmpWage
{
    internal partial class Program
    {
        public class EmpWage
        {
            public void CheckEmp()
            {
                int isFullTime = 1;
                int EmployeeWagePerHour = 20;
                int EmpDailyHour;

                Random rand = new Random();
                int Check = rand.Next(2);

                if (Check == isFullTime)
                {
                    Console.WriteLine("Employee is Present");
                    EmpDailyHour = 8;

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