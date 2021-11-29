using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Application.TimelineItemsQueryList;
using AutoWrapper.Models;
using AutoWrapper.Wrappers;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace WebAPI.Controllers
{
    public class TimelineItemsController : WebApiController
    {
        public TimelineItemsController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Route("timelineItems")]
        [ProducesResponseType(typeof(IEnumerable<TimelineItemDTO>), Status200OK)]
        [ProducesResponseType(typeof(ApiProblemDetailsResponse), Status500InternalServerError)]
        public async Task<ApiResponse> GetAllAsync()
        {
            return new ApiResponse(await Send(new GetAllTimelineItemsQuery()));
        }
    }
}