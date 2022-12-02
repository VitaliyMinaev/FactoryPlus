using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryForm.Domain.Abstract
{
    public abstract class PersonBase 
    {
        public string PersonId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string WorkShopId { get; set; }

        public PersonBase(string name, string workshopId)
        {
            Name = name;
            WorkShopId = workshopId;
        }
    }
}
