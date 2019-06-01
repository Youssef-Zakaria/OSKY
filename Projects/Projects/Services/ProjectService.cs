using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projects.Interfaces;
using Projects.Models;

namespace Projects.Services
{
    public class ProjectService : IProjectService
    {
        static List<Project> _projects = new List<Project>() {
            new Project() {
                ID = 1 , ProjectName = "Project 1" , ProjectDetails = "Project 1 Details + elra8y el shehab 3AYZO" , StartDate = new DateTime(2015,4,13) ,
                EndDate = new DateTime(2018,5,20),Location = "Cairo" ,  Logo = "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png" ,
                Images = new List<ProjectImage>()
                {
                    new ProjectImage() {ImageDescription = "Project 1 Image 1" , ImageURL = "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png"},
                    new ProjectImage() {ImageDescription = "Project 1 Image 2" , ImageURL = "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg"},
                    new ProjectImage() {ImageDescription = "Project 1 Image 3" , ImageURL = "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png"},
                }
            },
            new Project() {
                ID = 2 , ProjectName = "Project 2" , ProjectDetails = "Project 2 Details + elra8y el shehab 3AYZO" , StartDate = new DateTime(2016,5,14) ,
                EndDate = new DateTime(2018,5,20),Location = "Cairo" ,  Logo = "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg" ,
                Images = new List<ProjectImage>()
                {
                    new ProjectImage() {ImageDescription = "Project 2 Image 1" , ImageURL = "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png"},
                    new ProjectImage() {ImageDescription = "Project 2 Image 2" , ImageURL = "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg"},
                    new ProjectImage() {ImageDescription = "Project 2 Image 3" , ImageURL = "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png"},
                }
            },
            new Project() {
                ID = 3 , ProjectName = "Project 3" , ProjectDetails = "Project 3 Details + elra8y el shehab 3AYZO" , StartDate = new DateTime(2017,6,15) ,
                EndDate = new DateTime(2018,5,20),Location = "Cairo" ,  Logo = "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png" ,
                Images = new List<ProjectImage>()
                {
                    new ProjectImage() {ImageDescription = "Project 3 Image 1" , ImageURL = "https://cdn4.iconfinder.com/data/icons/black-icon-social-media/512/099310-feedburner-logo.png"},
                    new ProjectImage() {ImageDescription = "Project 3 Image 2" , ImageURL = "https://image.shutterstock.com/image-vector/heart-vector-symbol-valentines-day-260nw-569390800.jpg"},
                    new ProjectImage() {ImageDescription = "Project 3 Image 3" , ImageURL = "http://icons.iconarchive.com/icons/dan-wiersma/apple-tv/256/Apple-Logo-icon.png"},
                }
            },
        };
        

        public Project GetProject(int id)
        {
            return _projects.FirstOrDefault(proj => proj.ID == id);
        }

        public List<ProjectListing> GetProjectListings()
        {
            return _projects.Select(proj => new ProjectListing() { ID = proj.ID , Logo = proj.Logo, ProjectDetails = proj.ProjectDetails , ProjectName = proj.ProjectName  }).ToList();
        }
    }
}
