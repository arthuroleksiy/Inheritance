using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InheritanceTask
{
    
    public class Company
    {
        private Employee[] employees;

        public Company(IEnumerable<Employee> employees)
        {
            this.employees = Enumerable.ToArray(employees);
        }

        public void GiveEverbodyBonus(decimal companyBonus)
        {
            for (int  i = 0; i < employees.Length; i++)
            {
                //employees[i].SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay()
        {
            decimal totalAmount = 0;
            for(int i = 0; i < employees.Length; i++)
            {
                totalAmount += employees[i].ToPay();
            }

            return totalAmount;
        }

        public string NameMaxSalary()
        {
            string name = default;
            decimal largest = 0;
            for(int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ToPay() >= largest)
                {
                    largest = employees[i].ToPay();
                    name = employees[i].Name;
                }
            }

            return name;
        }
    }
}
