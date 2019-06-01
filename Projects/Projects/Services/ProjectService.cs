using System;
using System.Collections.Generic;
using System.Text;
using Projects.Interfaces;
using Projects.Models;

namespace Projects.Services
{
    public class ProjectService : IProjectService
    {
        static List<Project> _projects = new List<Project>() {
            new Project(){ ProjectName = "Project 1" , ProjectDetails = "Project 1 Details + elra8y e;l shehab 3AYZO" , StartDate = new DateTime(2015,4,13) , EndDate = new DateTime(2018,5,20),Location = "Cairo" , }
        };

        public List<Project> GetProjects()
        {
            return _projects;
        }
    }
}
