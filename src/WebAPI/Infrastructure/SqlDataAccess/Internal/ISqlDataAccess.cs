using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebAPI.Infrastructure.SqlDataAccess.Internal
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<TResponse>> LoadDataAsync<TResponse, dynamic>(string sql, dynamic parameters);
        Task<TResponse> LoadFirstOrDefaultAsync<TResponse, dynamic>(string sql, dynamic parameters);
    }
}