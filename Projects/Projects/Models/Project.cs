﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Models
{
    public class Project
    {
        public int ID { get; set; }
        public String ProjectName { get; set; }
        public String ProjectDetails { get; set; }
        public String Logo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Location { get; set; }
        public List<ProjectImage> Images { get; set; }    
    }

}
