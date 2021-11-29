using System;

namespace WebAPI.Entities
{
    public class TimelineItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}