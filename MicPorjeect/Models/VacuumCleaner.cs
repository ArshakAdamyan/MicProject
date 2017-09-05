using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicPorjeect.Models
{
    public class VacuumCleaner : BaseClass
    {
        public int MaximumPower { get; set; }
        public int SuctionPower { get; set; }
        public double DustBagCapacity { get; set; }

        public VacuumCleaner(int Id)
            :base(Id)
        {

        }
        public VacuumCleaner(string Company)
            :base (Company)
        {

        }
        public VacuumCleaner(string Company, string Name)
            :base (Company,Name)
        {

        }
        public VacuumCleaner(long Price)
            :base (Price)
        {

        }
        public VacuumCleaner(int Id, string Company, string Name, long Price, int MaximumPower, int SuctionPower, double DustBagCapacity ) 
            :base(Company,Name,Price)
        {
            this.Id = Id;
            this.MaximumPower = MaximumPower;
            this.SuctionPower = SuctionPower;
            this.DustBagCapacity = DustBagCapacity;
        }
    }
}
