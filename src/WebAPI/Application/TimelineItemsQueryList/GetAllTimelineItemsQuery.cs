using MediatR;
using System.Collections.Generic;

namespace WebAPI.Application.TimelineItemsQueryList
{
    public class GetAllTimelineItemsQuery : IRequest<IEnumerable<TimelineItemDTO>>
    {

    }
}