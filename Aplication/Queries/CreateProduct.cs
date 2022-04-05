using Domain;
using MediatR;
using Persistence;

namespace Aplication.Queries
{
    public class CreateProduct
    {
        public class Command:IRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Cost { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly StoreContext _context;
            public Handler(StoreContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = new Product()
                {
                    Id = request.Id,
                    Name = request.Name,
                    Cost = request.Cost
                };
                await _context.Products.AddAsync(product);
                if(await _context.SaveChangesAsync()>0)return Unit.Value;
                throw new Exception("Fail to save");
            }
        }
    }
}