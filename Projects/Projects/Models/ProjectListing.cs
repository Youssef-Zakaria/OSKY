using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Models
{
    public class ProjectListing
    {
        public int ID { get; set; }
        public String ProjectName { get; set; }
        public String ProjectDetails { get; set; }
        public String StartDate { get; set; }
        public String EndDate { get; set; }
        public String Location { get; set; }
        public String Logo { get; set; }
    }
}
