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
            new Project(){ ProjectName = "Project 1" , ProjectDetails = "Project 1 Details + elra8y el shehab 3AYZO" , StartDate = new DateTime(2015,4,13) , EndDate = new DateTime(2018,5,20),Location = "Cairo" ,  ProjectLogo = "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png" , ImageUrls = new String[] { "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png" , "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg" , "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png" } },
        new Project() { ProjectName = "Project 2" , ProjectDetails = "Project 2 Details + elra8y el shehab 3AYZO" , StartDate = new DateTime(2015, 5, 14) , EndDate = new DateTime(2018, 6, 21),Location = "Giza" ,  ProjectLogo = "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg" , ImageUrls = new String[] { "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png", "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg", "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png" } },
        new Project() { ProjectName = "Project 3" , ProjectDetails = "Project 3 Details + elra8y el shehab 3AYZO" , StartDate = new DateTime(2015, 6, 15) , EndDate = new DateTime(2018, 7, 22),Location = "Alex" ,  ProjectLogo = "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png" , ImageUrls = new String[] { "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png", "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg", "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png" } }
        };

        public List<Project> GetProjects()
        {
            return _projects;
        }
    }
}
