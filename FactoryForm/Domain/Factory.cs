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
                if (_workShops == null)
                    return 0;

                return _workShops.Count;
            }
            private set { }
        }
        public int CountOfEmployee 
        { 
            get
            {
                if (_employees == null)
                    return 0;
                int count = 0;
                foreach (var pair in _employees)
                {
                    if (IsEmployee(pair.Key) == true)
                        count += 1;
                }
                return count;
            }
            private set { }
        }
        public int CountOfMasters
        {
            get
            {
                if (_employees == null)
                    return 0;
                int count = 0;
                foreach (var pair in _employees)
                {
                    if (IsEmployee(pair.Key) == false)
                        count += 1;
                }
                return count;
            }
            private set { }
        }
        public string CountOfDetails { get; set; }

        private List<Workshop> _workShops;
        public List<Workshop> WorkShops 
        {
            get => _workShops;
            set => _workShops = value;
        }
        private Dictionary<string, PersonBase> _employees;
        public Dictionary<string, PersonBase> Employees
        {
            get => _employees;
            set => _employees = value;
        }

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
                _employees.Add($"Employee: {employee.PersonId}", employee);
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
                _employees.Add($"Master: {master.PersonId}", master);
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
        public bool FirePerson(Guid id)
        {
            foreach (var item in _employees)
            {
                if (item.Value.PersonId == id.ToString())
                {
                    _employees.Remove(item.Key);
                    return true;
                }
            }

            return false;
        }
        public bool FirePerson(string personName)
        {
            foreach (var item in _employees)
            {
                if (item.Value.Name == personName)
                {
                    _employees.Remove(item.Key);
                    return true;
                }
            }

            return false;
        }
        public IEnumerable<PersonBase> GetPersons()
        {
            foreach (var item in _employees)
            {
                yield return item.Value;
            }
        }
        public PersonBase GetPersonByName(string personName)
        {
            foreach (var item in _employees)
            {
                if (item.Value.Name == personName)
                {
                    return item.Value;
                }
            }

            throw new ArgumentException($"Can not find person with name: {personName}");
        }


        public void AddWorkshop(Workshop workshop)
        {
            _workShops.Add(workshop);
        }
        public void RemoveWorkshop(Workshop workshop)
        {
            _workShops.Remove(workshop);
        }
        public IEnumerable<Workshop> GetWorkshops()
        {
            foreach (var item in _workShops)
            {
                yield return item;
            }
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
        private bool IsEmployee(string key)
        {
            if(key.StartsWith("Employee: ") == true)
            {
                return true;
            }
            else if(key.StartsWith("Master: ") == true)
            {
                return false;
            }

            throw new ArgumentException("Invalid key format");
        }
    }
}