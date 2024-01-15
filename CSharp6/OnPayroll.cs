using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    internal class OnPayroll:Employee
    {
        public DateOnly joiningDate {  get; set; }
        public int exp {  get; set; }
        public float basicSalary { get; set; }
        public float da {  get; set; }
        public float hra {  get; set; }
        public float pf {  get; set; }
        public float netSalary { get; set; }
        public OnPayroll(): base() { }
        public OnPayroll(int uniqueId, string name, string reportingManager, DateOnly joiningDate, int exp, float basicSalary, float da, float hra,float pf,float netSalary):base( uniqueId,  name,  reportingManager)
        {
            this.joiningDate = joiningDate;
            this.exp = exp;
            this.basicSalary = basicSalary;
            this.da = da;
            this.hra = hra;
            this.pf = pf;
            this.netSalary = netSalary;
        }
        public override void Get()
        {
            base.Get();
            Console.WriteLine("Enter joining date");
            joiningDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter experience in years");
            exp=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter basic salary");
            basicSalary=float.Parse(Console.ReadLine());
            NetSalary();
            
        }
        public void NetSalary()
        {
            if (exp > 10)
            {
                da = (10 * basicSalary) / 100;
                hra = (85 * basicSalary) / 1000;
                pf = 6200;
            }
            else
            if (exp > 7 && exp < 10)
            {
                da = (7 * basicSalary) / 100;
                hra = (65 * basicSalary) / 1000;
                pf = 4100;

            }
            else
            if (exp > 5 && exp < 7)
            {
                da = (41 * basicSalary) / 1000;
                hra = (38 * basicSalary) / 1000;
                pf = 1800;

            }
            else
                if (exp < 5)
            {
                da = (19 * basicSalary) / 1000;
                hra = (20 * basicSalary) / 1000;
                pf = 1200;

            }
            netSalary = basicSalary + da + hra - pf;

        }

    }
}
