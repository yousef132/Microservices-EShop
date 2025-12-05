namespace Catalog.API.Products.CreateProduct
{

    public record CreateProductRequest(string Name,
        string Description,
        List<string> Categories,
        decimal Price,
        string Imagefile);

    public record CreateProductResponse(Guid Id);
    public class CreateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/products", async (CreateProductRequest request, ISender mediator, CancellationToken cancellationToken) =>
            {
                var command = request.Adapt<CreateProductCommand>();
                var result = await mediator.Send(command, cancellationToken);
                var response = result.Adapt<CreateProductResponse>();
                return Results.Created($"/products/{response.Id}", response);
            }).WithName("CreateProduct")
              .Produces<CreateProductResponse>(StatusCodes.Status201Created)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Create Product")
              .WithDescription("Create Product");
        }
    }
}
