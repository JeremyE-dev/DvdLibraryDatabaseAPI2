using DvdLibraryDatabaseAPI2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DvdLibraryDatabaseAPI2
{
    public class DvdLibraryEntities : DbContext
    {
        public DvdLibraryEntities()
            : base("DvdLibraryEF")
        {

        }

        public DbSet<Dvd> Dvds { get; set; }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ReleaseYear> ReleaseYears { get; set; }
    }
}