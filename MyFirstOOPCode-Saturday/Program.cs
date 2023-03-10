using System;

namespace MyFirstOOPCode_Saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObjectBirthDate = new Date(1928, 2, 8);
                var dateObjectHiringDate = new Date(2023, 1, 1);
                
                Console.WriteLine("");

                Console.WriteLine("**********************");
                Console.WriteLine("* SALARY EMPLOYEE *");
                Console.WriteLine("**********************");

                Console.WriteLine("");

                Employee salaryEmployeedObject = new SalaryEmployee()
                {              
                    Id = 104550581,
                    FirstName = "Maria",
                    LastName = "Sandoval",
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = true,
                    Salary = 1600000.56M,
                };

                SalaryEmployee salaryEmployee = new SalaryEmployee();

                salaryEmployee.Salary = 1600000;
                    
                Console.WriteLine(salaryEmployee.ToString());

                Console.WriteLine("");

                Console.WriteLine("**********************");
                Console.WriteLine("* COMISSION EMPLOYEE *");
                Console.WriteLine("**********************");

                Console.WriteLine("");

                Console.WriteLine("Type your ID:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name:");
                string FirstName = Console.ReadLine();

                Console.WriteLine("Type your last name:");
                string LastName = Console.ReadLine();

                Console.WriteLine("Are you active ?:");
                bool IsActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Type your comission in percentage:");
                float commissionPercentage = Convert.ToSingle(Console.ReadLine()); 
                commissionPercentage = commissionPercentage/100;

                Console.WriteLine("Type your sales:");
                decimal sales = Convert.ToDecimal(Console.ReadLine());  

                Employee comissionEmployee = new ComissionEmployee() 
                { 
                    Id= id,
                    FirstName = FirstName,
                    LastName = LastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,   
                    IsActive = IsActive,
                    ComissionPercentage= commissionPercentage,
                    Sales = sales,  
                };

                Console.WriteLine(comissionEmployee.ToString());

                Console.WriteLine("");














            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
