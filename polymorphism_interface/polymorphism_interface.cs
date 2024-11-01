using System;

namespace ClassAssignment
{


    interface IQuittable
    {
        void Quit(Employee employee);

    }

    public class Employee : IQuittable
    {
        //setting properties
        //adding isActive; true means currently employed
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool isActiveEmployee { get; set; }

        //constructor
        //
        public Employee(int id)
        {
            this.EmployeeID = id;
            this.isActiveEmployee = true; // when someone is added default value is set to true.
        }

        public Employee(int id, string firstName, string lastName) : this(id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void Quit(Employee employee)
        {
            isActiveEmployee = false;
            Console.WriteLine("Employee {0} {1} has been terminated.", FirstName, LastName);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var A = new Employee(1, "John", "Smith");
            var B = new Employee(2, "Tom", "Black");

            Console.WriteLine("A.isActiveEmployee: " + A.isActiveEmployee);
            A.Quit(A);
            Console.WriteLine("A.isActiveEmployee: " + A.isActiveEmployee); //test of Quit function
            //Quit() has been succesfully implemented as an interface.

        
        }
    }
}