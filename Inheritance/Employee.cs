using System;

namespace InheritanceTask
{
    public class Employee
    {
        private string name;
        private readonly decimal salary;
        private decimal bonus;

        public string Name {
            get { return name; }
        }

        public decimal Salary {
            get { return salary; }
        }

        public Employee (string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
        /*
        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }*/

        public decimal ToPay()
        {
            return bonus + salary;
        }
    }


}