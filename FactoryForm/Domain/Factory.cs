using FactoryForm.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryForm.Domain
{
    public class Factory : IComparable<Factory>
    {
        /* Properties */
        public string Title { get; set; }

        public int CountOfWorkshop 
        { 
            get
            {
                return _workShops.Count;
            }
            private set => CountOfWorkshop = value; 
        }
        public int CountOfEmployee 
        { 
            get
            {
                int count = 0;
                foreach (var pair in _employees)
                {
                    if (pair.Value is Employee)
                        count += 1;
                }
                return count;
            }
            private set => CountOfEmployee = value;
        }
        public int CountOfMasters
        {
            get
            {
                int count = 0;
                foreach (var pair in _employees)
                {
                    if (pair.Value is Master)
                        count += 1;
                }
                return count;
            }
            private set => CountOfMasters = value;
        }
        public string CountOfDetails { get; private set; }

        private List<Workshop> _workShops;
        private Dictionary<string, PersonBase> _employees;


        /* Money contains in cents (type integer) */
        public int EmployeeSalary { get; set; }
        public int MasterSalary { get; set; }

        /* Profit for 1 month */
        public int ProfitFromEmployee { get; set; }
        public int ProfitFromMaster { get; set; }

        public Factory()
        {
            Title = String.Empty;

            CountOfWorkshop = CountOfEmployee = CountOfMasters = 0;
            EmployeeSalary = MasterSalary = 0;
            ProfitFromEmployee = ProfitFromMaster = 0;

            _employees = new Dictionary<string, PersonBase>();
            _workShops = new List<Workshop>();
        }

        public Factory(string titleOfFactory, int employeeSalary, int masterSalary, int profitFromEmployee, int profitFromMaster)
        {
            Title = titleOfFactory;
            EmployeeSalary = employeeSalary;
            MasterSalary = masterSalary;
            ProfitFromEmployee = profitFromEmployee;
            ProfitFromMaster = profitFromMaster;

            _employees = new Dictionary<string, PersonBase>();
            _workShops = new List<Workshop>();
        }

        public Factory(string titleOfFactory, IEnumerable<Workshop> workshops,
            IEnumerable<PersonBase> employee)
        {
            Title = titleOfFactory;
            _workShops = workshops.ToList();

            _employees = employee.Select(x => new { x.PersonId, x } )
                .ToDictionary(x => x.PersonId, x => x.x);
        }

        /* Copy Constructor */
        public Factory(Factory other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            Title = other.Title;
            _workShops = other._workShops;
            _employees = other._employees;

            EmployeeSalary = other.EmployeeSalary;
            MasterSalary = other.MasterSalary;
            ProfitFromEmployee = other.ProfitFromEmployee;
            ProfitFromMaster = other.ProfitFromMaster;
        }


        /* Business logic */
        public bool HireEmployee()
        {
            if (EstimateNumberOfEmployeeAndMaster(CountOfEmployee + 1, CountOfMasters))
            {
                CountOfEmployee += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HireMaster()
        {
            if (EstimateNumberOfEmployeeAndMaster(CountOfEmployee, CountOfMasters + 1))
            {
                CountOfMasters += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HireEmployee(Employee employee)
        {
            if (EstimateNumberOfEmployeeAndMaster(CountOfEmployee + 1, CountOfMasters))
            {
                _employees.Add(employee.PersonId, employee);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HireMaster(Master master)
        {
            if (EstimateNumberOfEmployeeAndMaster(CountOfEmployee, CountOfMasters + 1))
            {
                _employees.Add(master.PersonId, master);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FireEmployee()
        {
            if (EstimateNumberOfEmployeeAndMaster(CountOfEmployee - 1, CountOfMasters))
            {
                CountOfEmployee -= 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FireMaster()
        {
            if (EstimateNumberOfEmployeeAndMaster(CountOfEmployee, CountOfMasters - 1))
            {
                CountOfMasters -= 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FirePerson(string personId)
        {
            foreach (var item in _employees)
            {
                if (item.Value.PersonId == personId)
                {
                    _employees.Remove(item.Key);
                    return true;
                }
            }

            return false;
        }

        public int CompareTo(Factory other)
        {
            if (other == null)
            {
                throw new ArgumentNullException($"Comparable factory can not be null");
            }

            if (this.CountOfWorkshop > other.CountOfWorkshop 
                && this.CountOfEmployee > other.CountOfEmployee
                && this.CountOfMasters > other.CountOfMasters)
            {
                return 1;
            }
            else if (this.CountOfWorkshop < other.CountOfWorkshop
                && this.CountOfEmployee < other.CountOfEmployee
                && this.CountOfMasters < other.CountOfMasters)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private bool EstimateNumberOfEmployeeAndMaster(int countOfEmployee, int countOfMasters)
        {
            if (countOfEmployee <= countOfMasters * 10 && (countOfEmployee == 0 || countOfMasters * 10 - countOfEmployee <= 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}