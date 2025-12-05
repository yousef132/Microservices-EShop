using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{

    public record CreateProductCommand(string Name,
        string Description,
        List<string> Categories,
        decimal Price,
        string Imagefile
    ) : ICommand<CreateProductResult>;

    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public CreateProductCommandHandler()
        {

        }
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {

            var product = new Product
            {
                Name = command.Name,
                Description = command.Description,
                Categories = command.Categories,
                Price = command.Price,
                Imagefile = command.Imagefile
            };
            // TODO :: save to db
            return new CreateProductResult(Guid.NewGuid());
        }
    }


}
