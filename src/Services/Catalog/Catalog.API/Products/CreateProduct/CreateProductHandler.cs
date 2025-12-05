using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{

    public record CreateProductCommand(string Name,
        string Description,
        List<string> Categories,
        decimal Price,
        string Imagefile
    ) : IRequest<CreateProductResult>;

    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public CreateProductCommandHandler()
        {

        }
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            var product = new Product
            {

            };
            throw new NotImplementedException();
        }
    }
}
