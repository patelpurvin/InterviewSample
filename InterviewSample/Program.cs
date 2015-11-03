using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InterviewSample
{
    delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
     
        public static void PromoteEmployee(List<Employee> employeelist,IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeelist)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted ");
                }
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "Purvin", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 102, Name = "Purvin1", Salary = 4000, Experience = 4 });
            emplist.Add(new Employee() { ID = 103, Name = "Purvin2", Salary = 6000, Experience = 6 });
            emplist.Add(new Employee() { ID = 104, Name = "Purvin3", Salary = 3000, Experience = 3 });
            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(emplist,isPromotable);
            Console.ReadLine();
        }
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }

    }
}
