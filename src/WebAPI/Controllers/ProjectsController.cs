using MediatR;
using WebAPI.Application.ProjectsQueryList;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoWrapper.Wrappers;
using AutoWrapper.Models;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace WebAPI.Controllers
{
    public class ProjectsController : WebApiController
    {
        public ProjectsController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Route("projects")]
        [ProducesResponseType(typeof(IEnumerable<ProjectDTO>), Status200OK)]
        [ProducesResponseType(typeof(ApiProblemDetailsResponse), Status500InternalServerError)]
        public async Task<ApiResponse> GetAllAsync()
        {
            return new ApiResponse(await Send(new GetAllProjectsQuery()));
        }
    }
}