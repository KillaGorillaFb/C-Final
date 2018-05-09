using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// Developer:  Frankie Barrios
    /// Date:       5/2/2018
    /// Purpose:    Final Project - Employee Form
    /// </summary>
    class EmployeeClass
    {
        #region Fields
        private string firstName;
        private string lastName;
        private string employeeType;
        private double salary;
        #endregion


        #region Constructors
        public EmployeeClass(string lastName, string firstName, string employeeType, int salary)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.employeeType = employeeType;
            this.salary = salary;
        }

        public EmployeeClass()
        {
        }

        #endregion

        #region Getters/ Setters
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string EmployeeType
        {
            get
            {
                return employeeType;
            }

            set
            {
                employeeType = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return lastName + ", " + firstName + ", " + employeeType + ", " + salary;
        }

        #endregion
    }
}
