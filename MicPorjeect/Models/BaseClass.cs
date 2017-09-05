using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicPorjeect.Models
{
    abstract public class BaseClass
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }

        public BaseClass(int Id)
        {
            this.Id = Id;
        }
        public BaseClass(string Company)
        {
            this.Company = Company;
        }
        public BaseClass(string Company, string Name)
        {
            this.Company = Company;
            this.Name = Name;
        }
        public BaseClass(long Price)
        {
            this.Price = Price;
        }
        public BaseClass(string Company, string Name, long Price)
        {
            this.Price = Price;
            this.Company = Company;
            this.Name = Name;
        }
    }
}
