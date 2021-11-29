using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class WebApiController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WebApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<T> Send<T>(IRequest<T> query, CancellationToken token = default)
        {
            return await _mediator.Send(query, token);
        }
    }
}