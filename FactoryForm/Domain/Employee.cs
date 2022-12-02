﻿using FactoryForm.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryForm.Domain
{
    public class Employee : PersonBase
    {
        const int _salary = 1500000;
        public int Salary
        {
            get => _salary;
        }
        public bool HigherTechnicalEducation { get; set; }

        public Employee(string name, string workshopId, bool higherTechnicalEducation)
            : base (name, workshopId)
        {
            HigherTechnicalEducation = higherTechnicalEducation;
        }
    }
}
