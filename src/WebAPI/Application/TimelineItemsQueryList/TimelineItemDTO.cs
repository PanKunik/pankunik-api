using System;
using WebAPI.Application.Common;
using WebAPI.Entities;

namespace WebAPI.Application.TimelineItemsQueryList
{
    public class TimelineItemDTO : IMapFrom<TimelineItem>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}