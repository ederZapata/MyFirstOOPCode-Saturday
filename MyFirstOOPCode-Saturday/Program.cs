﻿using System;
using System.Collections;
using System.Collections.Generic;

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

                //Console.WriteLine(comissionEmployee.ToString());

                Console.WriteLine("");

                Console.WriteLine("**********************");
                Console.WriteLine("* HOURLY EMPLOYEE *");
                Console.WriteLine("**********************");

                Console.WriteLine("");

                Console.WriteLine("Type your ID:");
                 id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name:");
                 FirstName = Console.ReadLine();

                Console.WriteLine("Type your last name:");
                LastName = Console.ReadLine();

                Console.WriteLine("Are you active ?:");
                IsActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Type your number of hours:");
                float Hours  = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Are your value per hour:");
                decimal HourValue = Convert.ToDecimal(Console.ReadLine());

                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = id,
                    FirstName = FirstName,
                    LastName = LastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = IsActive,
                    Hours = Hours,
                };

                //Console.WriteLine(hourlyEmployee.ToString());

                Console.WriteLine("");

                Console.WriteLine("****************************");
                Console.WriteLine("* BASE COMISSION EMPLOYEE *");
                Console.WriteLine("***************************");

                Console.WriteLine("");

                Console.WriteLine("Type your ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name:");
                FirstName = Console.ReadLine();

                Console.WriteLine("Type your last name:");
                LastName = Console.ReadLine();

                Console.WriteLine("Are you active ?:");
                IsActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Type your comission in percentage:");
                commissionPercentage = Convert.ToSingle(Console.ReadLine());
                commissionPercentage = commissionPercentage / 100;

                Console.WriteLine("Type your sales:");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Type your salary base per hour:");
                decimal baseSalary = Convert.ToDecimal(Console.ReadLine());                

                Console.WriteLine("")

                Employee baseComissionEmployee = new BaseComissionEmployee();
                {
                    Id = id,
                    FirstName = FirstName,
                    LastName = LastName,
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = IsActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales,
                    Base = baseSalary,
                };

                //Console.WriteLine(baseComissionEmployee.ToString());
                decimal payroll = 0;
                //decimal payroll2 = 0;
                List<string> names = new List<string>();

                ICollection<Employee> employees = new List<Employee>()
                {
                    salaryEmployee,
                    comissionEmployee,
                    hourlyEmployee,
                    baseComissionEmployee,
                };

                foreach (Employee employees in employees) 
                {
                    if (employees.IsActive == true) 
                    {
                        Console.WriteLine(employees);
                        names.Add(employees.FirstName);
                        payroll += employees.GetValuesToPay();
                        Console.WriteLine("");
                    }                      
                }

                foreach (string name in names) 
                { 
                    Console.WriteLine(name);
                    Console.WriteLine("");
                }

                //Console.WriteLine($"Total Payroll      {payroll:C2}");
                Console.WriteLine(String.Format("Total payrot     "payroll));

                Console.WriteLine("");

                Console.WriteLine("***********");
                Console.WriteLine("* INVOICE *");
                Console.WriteLine("***********");



            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
