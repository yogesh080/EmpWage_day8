namespace EmpWage
{
    internal partial class Program
    {

        public class EmpWage
        {
            const int EmployeeFullTime = 1;
            const int EmployeePartTime = 2;
            const int MaxWorkedDay = 20;
            const int EmpWagePerHour = 20;
            const int MaxWorkedHours = 100;

            public void CheckEmp()
            {
                int totalEmpWage = 0;
                int EmpDailyHour;
                int days = 0 , Total_Hours = 0;
               

                Random random = new Random();

                for ( days = 0; days < MaxWorkedDay || MaxWorkedDay <= Total_Hours ; days++)
                {
                    int Check = random.Next(3);

                    if (Check==EmployeeFullTime)
                    {
                        Console.WriteLine("Employee is present");
                        EmpDailyHour = 8;
                    }
                    else if (Check == EmployeePartTime)
                    {
                        Console.WriteLine("Employee is part time");
                        EmpDailyHour = 4;
                    }
                    else
                    {
                        Console.WriteLine("Employee is Absent");
                        EmpDailyHour=0;
                    }

                    //Total_Hours += EmpDailyHour;
                    int DailyWage = EmpWagePerHour * EmpDailyHour;
                    Console.WriteLine("Day:" + days + "hhh " + DailyWage);
                    totalEmpWage += DailyWage;

                }

                Console.WriteLine("TOTAL WAGE IS :" + totalEmpWage);
                Console.WriteLine("Days Completed:" + days + "Total Hours Completed: " + Total_Hours );



            }

        }
    }
}