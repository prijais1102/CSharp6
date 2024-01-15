using CSharp6;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    internal class Program
    {

        enum EmployeeType { OnContract = 1, OnPayRoll = 2, Record = 3 };
        static void Main(string[] args)
        {
            try
            {
                List<Employee> list = new List<Employee>();
                bool condition = true;
                bool condition1 = true;
                while (condition)
                {
                    Console.WriteLine("1.Add OnContract\n2.Add OnPayRoll\n3.More options.");
                    Console.WriteLine("Enter choice");
                    byte employeeType = byte.Parse(Console.ReadLine());
                    //Developer developer = null;
                    switch (employeeType)
                    {
                        case (byte)EmployeeType.OnContract:
                            OnContract onContract = null;
                            //developer = new OnContract();
                            //developer.GetDetails();
                            onContract = new OnContract();
                            onContract.Get();
                            list.Add(onContract);
                            condition1 = true;
                            while (condition1)
                            {
                                Console.WriteLine("Do you want to add more on-contract employees(y/n) ?");
                                char ch = char.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 'y':
                                        onContract = new OnContract();
                                        onContract.Get();
                                        list.Add(onContract);

                                        break;
                                    case 'n':
                                        condition1 = false;
                                        break;
                                }
                            }
                            break;
                        case (byte)EmployeeType.OnPayRoll:
                            //developer = new OnPayroll();
                            //developer.GetDetails();
                            OnPayroll onPayroll = null;
                            onPayroll = new OnPayroll();
                            onPayroll.Get();
                            list.Add(onPayroll);
                            condition1 = true;
                            while (condition1)
                            {
                                Console.WriteLine("Do you want to add more on-payRoll employees(y/n) ?");
                                char ch = char.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 'y':
                                        onPayroll = new OnPayroll();
                                        onPayroll.Get();
                                        list.Add(onPayroll);

                                        break;
                                    case 'n':
                                        condition1 = false;
                                        break;
                                }
                            }
                            break;
                        case (byte)EmployeeType.Record:
                            condition1 = true;
                            List<OnContract> onContractList = list.OfType<OnContract>().ToList();
                            List<OnPayroll> onPayrollList = list.OfType<OnPayroll>().ToList();
                            while (condition1)
                            {
                                Console.WriteLine("1.Display total no. of records & records");
                                Console.WriteLine("2.Display record of a particular employee");
                                Console.WriteLine("3.End");
                                Console.WriteLine("Enter Choice");
                                byte ch = byte.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:
                                        if (list.Count <= 0)
                                        {
                                            Console.WriteLine("No record found");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Total no of employees" + list.Count);
                                            if (onContractList.Count > 0)
                                            {
                                                for (int i = 0; i < onContractList.Count; i++)
                                                {
                                                    Console.WriteLine("On-Contract Employee");
                                                    Console.WriteLine("Id is " + onContractList[i].uniqueId);
                                                    Console.WriteLine("Name is " + onContractList[i].name);
                                                    Console.WriteLine("Joining date is " + onContractList[i].contractDate);
                                                    Console.WriteLine("Reporting manager is " + onContractList[i].reportingManager);
                                                    Console.WriteLine("Duration is " + onContractList[i].duration);
                                                    Console.WriteLine("Charges per day is " + onContractList[i].charges);
                                                    Console.WriteLine("Net salary is " + onContractList[i].netSalary);
                                                }
                                            }
                                            if (onPayrollList.Count > 0)
                                            {
                                                for (int i = 0; i < onPayrollList.Count; i++)
                                                {
                                                    Console.WriteLine("On-Payroll Employee");
                                                    Console.WriteLine("Id is " + onPayrollList[i].uniqueId);
                                                    Console.WriteLine("Name is " + onPayrollList[i].name);
                                                    Console.WriteLine("Reporting Manager is " + onPayrollList[i].reportingManager);
                                                    Console.WriteLine("Joining date is " + onPayrollList[i].joiningDate);
                                                    Console.WriteLine("Experience is " + onPayrollList[i].exp);
                                                    Console.WriteLine("Basic salary is " + onPayrollList[i].basicSalary);
                                                    Console.WriteLine("Da is " + onPayrollList[i].da);  
                                                    Console.WriteLine("Hra is " + onPayrollList[i].hra);
                                                    Console.WriteLine("Pf is " + onPayrollList[i].pf);
                                                    Console.WriteLine("Netsalary is " + onPayrollList[i].netSalary);

                                                }
                                            }
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter employee name to get his/her details");
                                        string str=Console.ReadLine();
                                        var record1 = onContractList.Where(x => x.name.Equals(str)).ToList();
                                        var record2=onPayrollList.Where(x => x.name.Equals(str)).ToList();
                                        if(record1.Count<=0&& record2.Count<=0)
                                        {
                                            Console.WriteLine("No record found");
                                        }
                                        else
                                        {
                                            if(record1.Count>0)
                                            {
                                                for (int i = 0; i < record1.Count; i++)
                                                {
                                                    Console.WriteLine("On-Contract Employee");
                                                    Console.WriteLine("Id is " + record1[i].uniqueId);
                                                    Console.WriteLine("Name is " + record1[i].name);
                                                    Console.WriteLine("Joining date is " + record1[i].contractDate);
                                                    Console.WriteLine("Reporting manager is " + record1[i].reportingManager);
                                                    Console.WriteLine("Duration is " + record1[i].duration);
                                                    Console.WriteLine("Charges per day is " + record1[i].charges);
                                                    Console.WriteLine("Net salary is " + record1[i].netSalary);
                                                }

                                            }
                                            if(record2.Count>0)
                                            {
                                                for (int i = 0; i < record2.Count; i++)
                                                {
                                                    Console.WriteLine("On-Payroll Employee");
                                                    Console.WriteLine("Id is " + record2[i].uniqueId);
                                                    Console.WriteLine("Name is " + record2[i].name);
                                                    Console.WriteLine("Reporting Manager is " + record2[i].reportingManager);
                                                    Console.WriteLine("Joining date is " + record2[i].joiningDate);
                                                    Console.WriteLine("Experience is " + record2[i].exp);
                                                    Console.WriteLine("Basic salary is " + record2[i].basicSalary);
                                                    Console.WriteLine("Da is " + record2[i].da);
                                                    Console.WriteLine("Hra is " + record2[i].hra);
                                                    Console.WriteLine("Pf is " + record2[i].pf);
                                                    Console.WriteLine("Netsalary is " + record2[i].netSalary);

                                                }

                                            }
                                        }

                                        break;
                                    
                                    
                                    case 3:
                                        condition1 = false;
                                        condition = false;
                                        break;
                                }
                            }

                            break;



                    }//switch
                }//while


            }//try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//catch

        }//main

    }//class
}//namespace
