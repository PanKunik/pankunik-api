using MediatR;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using WebAPI.Infrastructure.SqlDataAccess.TimelineItems;
using AutoMapper;

namespace WebAPI.Application.TimelineItemsQueryList
{
    public class GetAllTimelineItemsQueryHandler : IRequestHandler<GetAllTimelineItemsQuery, IEnumerable<TimelineItemDTO>>
    {
        private readonly ITimelineItemsDataAccess _timelineItemData;
        private readonly IMapper _mapper;

        public GetAllTimelineItemsQueryHandler(ITimelineItemsDataAccess timelineItemsData, IMapper mapper)
        {
            _timelineItemData = timelineItemsData;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TimelineItemDTO>> Handle(GetAllTimelineItemsQuery request, CancellationToken token = default)
        {
            var timelineItems = await _timelineItemData.GetTimelineItems();
            return _mapper.Map<IEnumerable<TimelineItemDTO>>(timelineItems);
        }
    }
}