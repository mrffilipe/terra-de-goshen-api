using Google.Cloud.Firestore;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly FirestoreDb _firestoreDb;

        public ProductRepository(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public async Task<Product> AddProduct(Product product)
        {
            try
            {
                var productCollection = _firestoreDb.Collection("Products");
                var productDoc = productCollection.Document(); // Cria um documento com ID gerado automaticamente
                product.Id = Guid.NewGuid();
                product.CreatedAt = DateTime.UtcNow;
                product.UpdatedAt = DateTime.UtcNow;

                // Convert ImageRef list to a list of dictionaries
                var images = product.Images?.Select(image =>
                {
                    var imageDoc = _firestoreDb.Collection("Images").Document(); // ID gerado automaticamente para ImageRef
                    image.Id = Guid.NewGuid();
                    image.CreatedAt = DateTime.UtcNow;
                    image.UpdatedAt = DateTime.UtcNow;

                    return new Dictionary<string, object>
                {
                    { "Id", image.Id.ToString() },
                    { "Details", new Dictionary<string, object> { { "Url", image.Details.Url } } },
                    { "CreatedAt", image.CreatedAt.ToUniversalTime() }, // Converte para Utc
                    { "UpdatedAt", image.UpdatedAt.ToUniversalTime() }  // Converte para Utc
                };
                }).ToList();

                var productData = new Dictionary<string, object>
            {
                { "Name", product.Name },
                { "Description", product.Description },
                { "Price", product.Price },
                { "Images", images },
                { "CreatedAt", product.CreatedAt.ToUniversalTime() }, // Converte para Utc
                { "UpdatedAt", product.UpdatedAt.ToUniversalTime() }, // Converte para Utc
                { "Colors", product.Colors?.Select(color => new Dictionary<string, object>
                    {
                        { "Id", color.Id.ToString() },
                        { "Details", new Dictionary<string, object> { { "Value", color.Details.Value } } },
                        { "CreatedAt", color.CreatedAt.ToUniversalTime() }, // Converte para Utc
                        { "UpdatedAt", color.UpdatedAt.ToUniversalTime() }  // Converte para Utc
                    }).ToList() },
                { "Sizes", product.Sizes?.Select(size => new Dictionary<string, object>
                    {
                        { "Id", size.Id.ToString() },
                        { "Details", new Dictionary<string, object> { { "Value", size.Details.Value } } },
                        { "CreatedAt", size.CreatedAt.ToUniversalTime() }, // Converte para Utc
                        { "UpdatedAt", size.UpdatedAt.ToUniversalTime() }  // Converte para Utc
                    }).ToList() },
                { "Category", new Dictionary<string, object>
                    {
                        { "Id", product.Category.Id.ToString() },
                        { "Details", new Dictionary<string, object> { { "Name", product.Category.Details.Name } } },
                        { "CreatedAt", product.Category.CreatedAt.ToUniversalTime() }, // Converte para Utc
                        { "UpdatedAt", product.Category.UpdatedAt.ToUniversalTime() }  // Converte para Utc
                    }
                },
                { "QuantityInStock", product.QuantityInStock }
            };

                await productDoc.SetAsync(productData);
                return product;
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> GetProductById(Guid id)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}