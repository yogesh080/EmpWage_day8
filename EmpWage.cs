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

        public void CheckEmp()
            {
                int totalEmpWage = 0;
                int EmpDailyHour;
                Random random = new Random();
                for (int i = 0; i < MaxWorkedDay; i++)
                {
                    int Check = random.Next(3);

                    if (Check==EmployeeFullTime)
                    {
                        Console.WriteLine("Employee is present");
                        EmpDailyHour = 8;
                    }
                    else if(Check == EmployeePartTime){
                        Console.WriteLine("Employee is part time");
                        EmpDailyHour = 4;
                    }
                    else
                    {
                        Console.WriteLine("Employee is Absent");
                        EmpDailyHour=0;
                    }
                int DailyWage = EmpWagePerHour * EmpDailyHour;
                Console.WriteLine(EmpDailyHour);
                totalEmpWage += DailyWage;

                }

                Console.WriteLine("TOTAL WAGE IS :" + totalEmpWage);



            }

        }
    }
}