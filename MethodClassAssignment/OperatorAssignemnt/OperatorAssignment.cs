using System;

namespace OperatorAssignment
{


    public class Employee
    {
        //setting properties
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //constructor
        public Employee(int id)
        {
            this.EmployeeID = id;
        }

        public Employee(int id, string firstName, string lastName) : this(id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var A = new Employee(1, "John", "Smith");
            var B = new Employee(1, "Tom", "Black");
            
            if(A.EmployeeID == B.EmployeeID)
            {
                Console.WriteLine("Employee ID must be unique.");
                Console.WriteLine("Employee {0} {1} and {2} {3} has the same ID. Please reset either.", A.FirstName, A.LastName, B.FirstName, B.LastName);
            }
        }
    }
}
