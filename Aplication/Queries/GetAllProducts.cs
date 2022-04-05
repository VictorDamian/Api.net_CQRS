using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Aplication.Queries
{
    public class GetAllProducts
    {
        public class Query:IRequest<List<Product>>{}
        public class Hanlder : IRequestHandler<Query, List<Product>>
        {
            public readonly StoreContext _context;

            public Hanlder(StoreContext context)
            {
                _context = context;
            }

            public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Products.ToListAsync();
            }
        }
    }
}