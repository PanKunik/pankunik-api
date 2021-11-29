using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Infrastructure.SqlDataAccess.TimelineItems
{
    public interface ITimelineItemsDataAccess
    {
        Task<IEnumerable<TimelineItem>> GetTimelineItems();
    }
}