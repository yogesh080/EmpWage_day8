namespace EmpWage
{
    internal partial class Program
    {

        public class EmpWage
        {
            /// <summary>
            /// This program is used to check whether employee is present or absent
            /// </summary>
            public void CheckEmp()
            {

                const int EmployeeFullTime = 1;
                const int EmployeePartTime = 2;

                int EmpWagePerHour = 20;
                int EmpDailyWork;
                Random r = new Random();

                int check = r.Next(3);

                switch (check)
                {
                    case EmployeeFullTime:
                        Console.WriteLine("Employee is Present");
                        EmpDailyWork = 8;
                        break;
                    case EmployeePartTime:
                        Console.WriteLine("Employee is Part time");
                        EmpDailyWork = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        EmpDailyWork = 0;
                        break;
                }


                int DailyWage = EmpWagePerHour * EmpDailyWork;
                Console.WriteLine("Employee daily wage is: " + DailyWage);
            }

        }
    }
}