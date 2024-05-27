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
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(Guid id)
        {
            throw new NotImplementedException();
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