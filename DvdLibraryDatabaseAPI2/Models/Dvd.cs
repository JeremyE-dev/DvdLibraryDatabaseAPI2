using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdLibraryDatabaseAPI2.Models
{
    public class Dvd
    {
        public int DvdId { get; set; }
        public int? DirectorId { get; set; }
        public int? RatingId { get; set; }

        public int? ReleaseYearId { get; set; }

        public string Title { get; set; }
        public string Notes { get; set; }


    }
}