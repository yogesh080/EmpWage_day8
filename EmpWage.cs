namespace EmpWage
{
    internal partial class Program
    {
        public class EmpWage
        {
            public void CheckEmp()
            {
                int isPresent=1;
                Random rand = new Random();
                int Check = rand.Next(0,2);

                if (Check == isPresent)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Absent");
                }

            }
        }
    }
}