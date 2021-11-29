using System;

namespace WebAPI.Entities
{
    public class Project 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Technologies { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}