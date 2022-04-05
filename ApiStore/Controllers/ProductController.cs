using Aplication.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            return await _mediator.Send(new GetAllProducts.Query());
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> PostProduct(CreateProduct.Command cmd)
        {
            return await _mediator.Send(cmd);
        }
    }
}