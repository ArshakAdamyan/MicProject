using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicPorjeect.Models
{
    public class AirConditioner : BaseClass
    {
        public float WorkingSpace { get; set; }
        public float AirFlow { get; set; }
        public float WorkingTemperature { get; set; }
        public AirConditioner(int Id)
            :base(Id)
        {

        }
        public AirConditioner(string Company)
            :base (Company)
        {

        }
        public AirConditioner(string Company, string Name)
            :base (Company,Name)
        {

        }
        public AirConditioner(long Price)
            :base (Price)
        {

        }
        public AirConditioner(int Id, string Name, string Company, float WorkingSpace, float AirFlow, long Price, float WorkingTemperature)
            :base(Company,Name,Price)
        {
            this.Id = Id;
            this.AirFlow = AirFlow;
            this.WorkingSpace = WorkingSpace;
            this.WorkingTemperature = WorkingTemperature;
        } 
    }                         
}                             