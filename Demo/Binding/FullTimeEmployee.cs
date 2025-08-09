using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class FullTimeEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }
        #endregion

        #region Constructors
        public FullTimeEmployee(int id, string name, int age, decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }
        #endregion

        #region Methods
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Fulltime Employee");
        }
        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"Salary = {Salary:c}");
        }
        #endregion
    }
}
