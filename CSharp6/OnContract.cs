using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    internal class OnContract:Employee
    {
        public DateOnly contractDate {  get; set; }
        public int duration {  get; set; }
        public int charges {  get; set; }
        public int netSalary {  get; set; }
        public OnContract() : base()
        {           
        }
        public OnContract(int uniqueId,string name,string reportingManager, DateOnly contractDate, int duration, int charges ,int netSalary) : base(uniqueId,name,reportingManager)
        {
            this.contractDate = contractDate;
            this.duration = duration;
            this.charges = charges;
            this.netSalary = netSalary;
        }
        public override void  Get()
        {
            base.Get();
            Console.WriteLine("Enter contract date");
            contractDate= DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter duration in months");
            duration =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter charges per month");
            charges = int.Parse(Console.ReadLine());
            NetSalary();

        }
        //public override void Display()
        //{
        //    base.Display();
        //    Console.WriteLine("contract date is " + contractDate);
        //    Console.WriteLine("duration is " + duration);
        //    Console.WriteLine("charges are" + charges);
        //    Console.WriteLine("netsalary is" + NetSalary(duration, charges));
        //}
        public int NetSalary()
        {
            netSalary= duration*charges;
            return netSalary;
        }

    }
}
