using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_50.Class
{
    class Employee
    {
        private string employeeName;

        private decimal basicSalary;
        private decimal percentageOfHouseRent;
        private decimal percentageOfMedicalAllowance;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public decimal BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        public decimal PercentageOfHouseRent
        {
            get { return percentageOfHouseRent; }
            set { percentageOfHouseRent = value; }
        }

        public decimal PercentageOfMedicalAllowance
        {
            get { return percentageOfMedicalAllowance; }
            set { percentageOfMedicalAllowance = value; }
        }

        /// <summary>
        /// Return total salary..
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalSalary()
        {
            return BasicSalary + GetHouseRentAmount() + GetMedicalAmount();
        }

        public decimal GetHouseRentAmount()
        {
            return BasicSalary*PercentageOfHouseRent/100;
        }

        public decimal GetMedicalAmount()
        {
            return BasicSalary*PercentageOfMedicalAllowance/100;
        }
    }
}
