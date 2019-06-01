using Projects.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Interfaces
{
    public interface IProjectService
    {
        List<Project> GetProjects();
    }
}
