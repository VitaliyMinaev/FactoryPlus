using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FactoryForm.Domain.Abstract
{
    public class PersonBase 
    {
        public string PersonId { get; set; }
        public string Name { get; set; }
        public string WorkShopId { get; set; }

        [JsonConstructor]
        public PersonBase()
        {
            PersonId = Guid.NewGuid().ToString();
            Name = WorkShopId = String.Empty;
        }

        public PersonBase(string name, string workshopId)
        {
            PersonId = Guid.NewGuid().ToString();
            Name = name;
            WorkShopId = workshopId;
        }
    }
}
