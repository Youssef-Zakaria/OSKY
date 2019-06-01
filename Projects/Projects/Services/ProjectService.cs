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
            
        };

        public List<Project> GetProjects()
        {
            return _projects;
        }
    }
}
