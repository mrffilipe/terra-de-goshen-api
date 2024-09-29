using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context), "O contexto de banco de dados não pode ser nulo.");
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "O produto não pode ser nulo.");
            }

            IList<Guid> colorIds = product.Colors.Select(x => x.Id).ToList();
            IList<ColorRef> existingColors = await _context.Colors
                .Where(x => colorIds.Contains(x.Id))
                .ToListAsync();

            IList<Guid> sizeIds = product.Sizes.Select(x => x.Id).ToList();
            IList<SizeRef> existingSizes = await _context.Sizes
                .Where(x => sizeIds.Contains(x.Id))
                .ToListAsync();

            var category = await _context.Categories.FirstOrDefaultAsync(x => product.CategoryId == x.Id);

            product.SetColors(existingColors);
            product.SetSizes(existingSizes);
            product.SetCategory(category);

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("O ID do produto é inválido.", nameof(id));
            }

            var result = await _context.Products
               .Include(x => x.Images)
               .Include(x => x.Colors)
               .Include(x => x.Sizes)
               .Include(x => x.Category)
               .SingleOrDefaultAsync(x => x.Id == id);

            if (result == null)
            {
                throw new KeyNotFoundException($"Produto com ID {id} não encontrado.");
            }

            return result;
        }

        public async Task<IList<Product>> GetProductsByNameAsync(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentException("O nome do produto não pode ser nulo ou vazio.", nameof(productName));
            }

            return await _context.Products
                .Where(p => p.Name.Contains(productName))
                .Include(p => p.Images)
                .Include(p => p.Colors)
                .Include(p => p.Sizes)
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(x => x.Images)
                .Include(x => x.Colors)
                .Include(x => x.Sizes)
                .Include(x => x.Category)
                .ToListAsync();
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "O produto não pode ser nulo.");
            }

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<IList<CategoryRef>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<IList<ColorRef>> GetAllColorsAsync()
        {
            return await _context.Colors.ToListAsync();
        }

        public async Task<IList<SizeRef>> GetAllSizesAsync()
        {
            return await _context.Sizes.ToListAsync();
        }
    }
}