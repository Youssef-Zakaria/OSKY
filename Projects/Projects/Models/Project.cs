using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Models
{
    public class Project
    {
        public String ProjectName { get; set; }
        public String ProjectDetails { get; set; }
        public String ProjectLogo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Location { get; set; }
        public String[] ImageUrls { get; set; }    
    }
}
