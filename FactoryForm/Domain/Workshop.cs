using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryForm.Domain
{
    public class Workshop
    {
        readonly private string _workShopId;
        public string WorkShopId 
        { 
            get => _workShopId;
        }
        public int CountOfWorkers { get; set; }
        public int MaxCapacity { get; set; }
        public int MaxCountOfMasters { get; set; }
        public int MaxCountOfEmployee { get; set; }
        public int CurrentMastersCount { get; set; }
        public int CurrentEmployeeCount { get; set; }
        public int CurrentDetailSelfCost { get; set; }

        private int _maxCountOfDetailsPerMaster;
        public int MaxCountOfDetailsPerMaster
        {
            get => _maxCountOfDetailsPerMaster;
            set => _maxCountOfDetailsPerMaster = value;
        }
        private int _maxCountOfDetailsPerEmployee;
        public int MaxCountOfDetailsPerEmployee
        {
            get => _maxCountOfDetailsPerEmployee;
            set => _maxCountOfDetailsPerEmployee = value;
        }
        private int _detailSelfCost;
        public int DetailSelfCost
        {
            get => _detailSelfCost;
            set => _detailSelfCost = value;
        }

        public Workshop()
        {
            _workShopId = Guid.NewGuid().ToString();

            CountOfWorkers = 0;
            MaxCapacity = 0;
            MaxCountOfMasters = 0;
            MaxCountOfEmployee = 0;
            CurrentMastersCount = 0;
            CurrentEmployeeCount = 0;
            CurrentDetailSelfCost = 0;
            _maxCountOfDetailsPerMaster = 0;
            _maxCountOfDetailsPerEmployee = 0;
            _detailSelfCost = 0;
        }
        public Workshop(int countOfWorkers, int maxCapacity, int maxCountOfMasters, int maxCountOfEmployee, int currentMastersCount, int currentEmployeeCount, int currentDetailSelfCost, int maxCountOfDetailsPerMaster, int maxCountOfDetailsPerEmployee, int detailSelfCost)
        {
            _workShopId = Guid.NewGuid().ToString();

            CountOfWorkers = countOfWorkers;
            MaxCapacity = maxCapacity;
            MaxCountOfMasters = maxCountOfMasters;
            MaxCountOfEmployee = maxCountOfEmployee;
            CurrentMastersCount = currentMastersCount;
            CurrentEmployeeCount = currentEmployeeCount;
            CurrentDetailSelfCost = currentDetailSelfCost;
            _maxCountOfDetailsPerMaster = maxCountOfDetailsPerMaster;
            _maxCountOfDetailsPerEmployee = maxCountOfDetailsPerEmployee;
            _detailSelfCost = detailSelfCost;
        }
    }
}
