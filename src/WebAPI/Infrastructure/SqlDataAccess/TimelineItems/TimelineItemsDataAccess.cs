using System.Threading.Tasks;
using System.Collections.Generic;
using WebAPI.Entities;
using WebAPI.Infrastructure.SqlDataAccess.Internal;

namespace WebAPI.Infrastructure.SqlDataAccess.TimelineItems
{
    public class TimelineItemsDataAccess : ITimelineItemsDataAccess
    {
        private readonly ISqlDataAccess _dataAccess;

        public TimelineItemsDataAccess(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<TimelineItem>> GetTimelineItems()
        {
            return await _dataAccess.LoadDataAsync<TimelineItem, dynamic>($@"SELECT * FROM dbo.TimelineItems", new { });
        }
    }
}