using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicPorjeect.Models
{
    public static class SampleData
    {
        public static void Initialize(Context context)
        {
            if (!context.WashingMachine.Any())
            {
                context.WashingMachine.AddRange(
                new WashingMachine
                (
                    Id: 0301,
                    Name: "FH2G6WDS7",
                    Company: "LG",
                    Price: 0,
                    Type: "Automatic",
                    SpinSpeed: 1200,
                    MaxDownloading: 6,
                    Downloading: "Front Downloading",
                    Dryer: 7,
                    Programs: 18
                ),
                new WashingMachine
                (
                    Id: 0302,
                    Name: "WLN2426EOE",
                    Company: "BOSCH",
                    Price: 0,
                    Type: "Automatic",
                    SpinSpeed: 1200,
                    MaxDownloading: 7,
                    Downloading: "Front Downloading",
                    Dryer: 8,
                    Programs: 16
                ),
                new WashingMachine
                (
                    Id : 0303,
                    Name : "WFEDJ7010S",
                    Company : "HISENCE",
                    Price : 0,
                    Type : "Automatic",
                    SpinSpeed : 1000,
                    MaxDownloading : 7,
                    Downloading : "Front Downloading",
                    Dryer : 8,
                    Programs : 14
                )
            );
            context.SaveChanges();
            }

            if (!context.VacuumCleaners.Any())
            {
                context.VacuumCleaners.AddRange(
                    new VacuumCleaner
                    (
                        Id: 0201,
                        Name : "BGL35 MOV15 RED",
                        Company : "BOSCH",
                        Price : 0,
                        SuctionPower : 320,
                        MaximumPower : 2200,
                        DustBagCapacity : 4
                    ),
                    new VacuumCleaner
                    (
                        Id : 0202,
                        Name : "ZVC752SP(919.OSP)",
                        Company : "ZELMER",
                        Price : 0,
                        SuctionPower : 280,
                        MaximumPower : 1600,
                        DustBagCapacity : 4
                    ),
                    new VacuumCleaner(
                        Id : 0203,
                        Name : "BBSG62186 RED&BLACK",
                        Company : "BOSCH",
                        Price : 0,
                        SuctionPower : 300,
                        MaximumPower : 2100,
                        DustBagCapacity : 4
                    )
                    );
                context.SaveChanges();
            }
            if (!context.AirConditioners.Any())
            {
                context.AirConditioners.AddRange(
                    new AirConditioner
                    (
                        Id : 0101,
                        Name : "VAC24IQE INVERTIER",
                        Company : "VIKASS",
                        Price : 0,
                        AirFlow : 1150,
                        WorkingSpace : 80,
                        WorkingTemperature : 0
                    ),
                     new AirConditioner
                     (
                         Id : 0102,
                         Name : "AST24UW4SDB TG10",
                         Company : "HISENCE",
                         Price : 0,
                         AirFlow : 1000,
                         WorkingSpace : 80,
                         WorkingTemperature : 0
                     ),
                     new AirConditioner
                     (
                         Id : 0103,
                         Name : "AS07HR4SYDTGR",
                         Company : "HISENCE",
                         Price : 0,
                         AirFlow : 460,
                         WorkingSpace : 20,
                         WorkingTemperature : +43 / -7
                    )
                    );
                context.SaveChanges();
            }

            if (!context.Freezers.Any())
            {
                context.Freezers.AddRange(
                    new Freezer
                    (
                        Id : 0001,
                        Company : "BOMPANI",
                        Name : "BRS26FD",
                        Price : 0,
                        Colour : "No",
                        Dimensions : 91*83*180,
                        NumberOfDoors : 2,
                        TotalCapacity : 650
                    ),
                        new Freezer
                    (
                            Id : 0002,
                            Company : "HISENCE",
                            Name : "RD22DC4SA",
                            Price : 0,
                            Colour : "Silver",
                            Dimensions : 50 * 55 * 143,
                            NumberOfDoors : 2,
                            TotalCapacity : 160
                    ),
                        new Freezer
                    (
                            Id : 0003,
                            Company : "HISENCE",
                            Name : "RD44WC4SBA/CKA1",
                            Price : 0,
                            Colour : "Inox",
                            Dimensions : 60 * 68 * 185,
                            NumberOfDoors : 2,
                            TotalCapacity : 322
                     )
                    );
                context.SaveChanges();
            }

        }
    }
}
