using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HarvestBands.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public IDbSet<Band> Bands { get; set; }
    }
}