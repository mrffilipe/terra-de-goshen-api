using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            try
            {
                _context.Products.Add(product);

                await _context.SaveChangesAsync();

                return product;
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            try
            {
                var result = await _context.Products
                    .Include(x => x.Images)
                    .Include(x => x.Colors)
                    .Include(x => x.Sizes)
                    .Include(x => x.Category)
                    .SingleAsync(x => x.Id.Equals(id));

                return result;
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            try
            {
                var result = await _context.Products
                    .Include(x => x.Images)
                    .Include(x => x.Colors)
                    .Include(x => x.Sizes)
                    .Include(x => x.Category)
                    .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> UpdateProductAsync(Product product)
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
    }
}