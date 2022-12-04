using FactoryForm.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FactoryForm.Domain
{
    public class Master : PersonBase
    {
        const int _salary = 4000000;
        public int Salary
        {
            get => _salary;
        }
        public int CountOfCertificates { get; set; }

        [JsonConstructor]
        public Master() : base() 
        {
            CountOfCertificates = -1;
        }

        public Master(string name, string workshopId, int countOfCertificates)
            : base(name, workshopId)
        {
            CountOfCertificates = countOfCertificates;
        }
    }
}
