using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HarvestBands.Models
{

    // creates test database
    class DatabaseInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var bands = new List<Band> {
                new Band {
                    School="AC Davis Senior High School", 
                    Disctrict="Yakima School District",
                    Division=Division.Exhibition, 
                    DirectorFirstName="Scotty",
                    DirectorLastName="Goranson",
                    PhoneNumber="509-456-4321",
                    Email="scottygandthepirates@yakimaschools.com",
                    BandNickName="The Davis High School Buccaneer Marching Band"
                },
                    new Band {
                    School="IKE", 
                    Disctrict="Yakima School District",
                    Division=Division.Exhibition, 
                    DirectorFirstName="David",
                    DirectorLastName="Walters",
                    PhoneNumber="509-456-4321",
                    Email="wally@yakimaschools.com"
                },
                    new Band {
                    School="Kennewick High School", 
                    Disctrict="Kennewick School District",
                    Division=Division.AA, 
                    DirectorFirstName="Dillon",
                    DirectorLastName="Miller",
                    PhoneNumber="509-222-7100",
                    Email="dillon.miller@ksd.org",
                    BandNickName="The Pride of the Mid Columbia Basin",
                    StreetAddress="500 S. Dayton St",
                    City="Kennewick",
                    ZipCode=99336,
                    BandSize=45,
                    PaidStatus=PaidStatus.Application_Received
                }    
            };

            foreach (var b in bands)
            {
                context.Bands.Add(b);
            }
        }


    }
}
