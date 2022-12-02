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
        public int MaxCapacity { get; private set; }
        public int MaxCountOfMasters { get; private set; }
        public int MaxCountOfEmployee { get; private set; }
        public int CurrentMastersCount { get; set; }
        public int CurrentEmployeeCount { get; set; }
        public int CurrentDetailSelfCost { get; private set; }

        readonly private int _maxCountOfDetailsPerMaster;
        readonly private int _maxCountOfDetailsPerEmployee;
        readonly private int _detailSelfCost;

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
