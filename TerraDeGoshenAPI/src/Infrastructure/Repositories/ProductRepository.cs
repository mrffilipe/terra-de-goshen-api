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
                IList<Guid> colorIds = product.Colors.Select(x => x.Id).ToList();

                IList<ColorRef> existingColors = await _context.Colors
                    .Where(x => colorIds.Contains(x.Id))
                    .ToListAsync();

                IList<Guid> sizeIds = product.Sizes.Select(x => x.Id).ToList();

                IList<SizeRef> existingSizez = await _context.Sizes
                    .Where(x => sizeIds.Contains(x.Id))
                    .ToListAsync();

                //product.UpdateColors(existingColors);
                //product.UpdateSizes(existingSizez);

                await _context.Products.AddAsync(product);

                await _context.SaveChangesAsync();

                return product;
            }
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IList<Product>> GetProductsByParametersAsync(SearchParameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IList<CategoryRef>> GetAllCategoriesAsync()
        {
            try
            {
                var result = await _context.Categories.ToListAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IList<ColorRef>> GetAllColorsAsync()
        {
            try
            {
                var result = await _context.Colors.ToListAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IList<SizeRef>> GetAllSizesAsync()
        {
            try
            {
                var result = await _context.Sizes.ToListAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}