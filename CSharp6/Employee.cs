namespace CSharp6
{
    internal class Employee
    {
        public int uniqueId {  get; set; }
        public string name { get; set; }
        public string reportingManager { get; set; }
        public Employee()
        { }
        public Employee(int uniqueId, string name, string reportingManager)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.reportingManager = reportingManager;
        }
             public virtual void Get()
        {
            Console.WriteLine("Enter Id");
            uniqueId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Reporting Manager");
            reportingManager = Console.ReadLine();
        }
        //public virtual void Display()
        //{
        //    Console.WriteLine("ID is" + uniqueId);
        //    Console.WriteLine("Name is " + name);
        //    Console.WriteLine("Reporting Manager is " + reportingManager);
        //}
    }

    }
