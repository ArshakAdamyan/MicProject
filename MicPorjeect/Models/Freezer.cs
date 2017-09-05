using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicPorjeect.Models
{
    public class Freezer : BaseClass
    {
        public int NumberOfDoors { get; set; }
        public float TotalCapacity { get; set; }
        public float Dimensions { get; set; }
        public string Colour { get; set; }
        public Freezer(int Id)
            :base(Id)
        {

        }
        public Freezer(string Company)
            :base (Company)
        {

        }
        public Freezer(string Company, string Name)
            :base (Company,Name)
        {

        }
        public Freezer(long Price)
            :base (Price)
        {

        }
        public Freezer(int Id, string Company, string Name, long Price, string Colour, float Dimensions, int NumberOfDoors, float TotalCapacity)
            :base(Company,Name,Price)
        {
            this.Id = Id;
            this.Colour = Colour;
            this.Dimensions = Dimensions;
            this.NumberOfDoors = NumberOfDoors;
            this.TotalCapacity = TotalCapacity;
        }
    }
}
