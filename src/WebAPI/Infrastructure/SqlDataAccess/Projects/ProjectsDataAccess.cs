using System.Threading.Tasks;
using WebAPI.Entities;
using System.Collections.Generic;
using WebAPI.Infrastructure.SqlDataAccess.Internal;

namespace WebAPI.Infrastructure.SqlDataAccess.Projects
{
    public class ProjectsDataAccess : IProjectsDataAccess
    {
        private readonly ISqlDataAccess _dataAccess;

        public ProjectsDataAccess(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<Project>> GetProjects()
        {
            return await _dataAccess.LoadDataAsync<Project, dynamic>($@"SELECT * FROM dbo.Projects", new { });
        }
    }
}