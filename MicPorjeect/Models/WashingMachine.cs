using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicPorjeect.Models
{
    public class WashingMachine : BaseClass
    {
        public string Type { get; set; }
        public float SpinSpeed { get; set; }
        public string Downloading { get; set; }
        public float Dryer { get; set; }
        public int Programs { get; set; }
        public float MaxDownloading { get; set; }
        public WashingMachine(int Id)
            :base(Id)
        {

        }
        public WashingMachine(string Company)
            :base (Company)
        {

        }
        public WashingMachine(string Company, string Name)
            :base (Company,Name)
        {

        }
        public WashingMachine(long Price)
            :base (Price)
        {

        }
        public WashingMachine(int Id, string Company, string Name, long Price, int Programs, float Dryer, string Downloading, float MaxDownloading, float SpinSpeed, string Type)
            :base(Company,Name,Price)
        {
            this.Id = Id;
            this.Programs = Programs;
            this.Dryer = Dryer;
            this.Downloading = Downloading;
            this.MaxDownloading = MaxDownloading;
            this.SpinSpeed = SpinSpeed;
            this.Type = Type;
        }
    }
}
