using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using WebAPI.Infrastructure.SqlDataAccess.Projects;
using AutoMapper;

namespace WebAPI.Application.ProjectsQueryList
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, IEnumerable<ProjectDTO>>
    {
        private readonly IProjectsDataAccess _projectsData;
        private readonly IMapper _mapper;

        public GetAllProjectsQueryHandler(IProjectsDataAccess projectsData, IMapper mapper)
        {
            _projectsData = projectsData;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProjectDTO>> Handle(GetAllProjectsQuery request, CancellationToken token = default)
        {
            var projects = await _projectsData.GetProjects();
            return _mapper.Map<IEnumerable<ProjectDTO>>(projects);
        }
    }
}