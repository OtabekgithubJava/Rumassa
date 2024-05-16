using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.Wishlists.Commands;
using Rumassa.Application.UseCases.Wishlists.Queries;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private readonly IMediator mediator;

        public WishlistController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishlist(AddToWishlistCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFromWishlist(RemoveFromWishlistCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetWishlist(GetAllFromWishlistsQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }
    }
}
