using System.Collections.Generic;
using MediatR;

namespace WebAPI.Application.ProjectsQueryList
{
    public class GetAllProjectsQuery : IRequest<IEnumerable<ProjectDTO>>
    {
        
    }
}