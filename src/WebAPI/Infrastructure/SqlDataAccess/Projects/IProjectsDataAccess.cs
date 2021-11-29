using System.Threading.Tasks;
using System.Collections.Generic;
using WebAPI.Entities;

namespace WebAPI.Infrastructure.SqlDataAccess.Projects
{
    public interface IProjectsDataAccess
    {
        Task<IEnumerable<Project>> GetProjects();
    }
}