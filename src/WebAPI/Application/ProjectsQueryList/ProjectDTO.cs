using System;
using WebAPI.Entities;
using WebAPI.Application.Common;

namespace WebAPI.Application.ProjectsQueryList
{
    public class ProjectDTO : IMapFrom<Project>
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Technologies { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}