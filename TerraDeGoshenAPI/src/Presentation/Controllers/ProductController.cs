using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.src.Presentation;

public class ProductController : BaseController
{
    //private readonly IProductService _productService;
    private readonly IList<Product> _products;

    public ProductController(/*IProductService productService*/)
    {
        //_productService = productService;

        _products = new List<Product>()
        {
            new Product(
                new Guid(),
                "Camiseta feminina Zatom bicicleta Preta",
                "",
                29.9,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://d8vlg9z1oftyc.cloudfront.net/ailos/image/product/7b1ed85e9ec6a3c690e9d8ceab110cfa20221020074114/850/camiseta-feminina-zatom-bicicleta_1928.png", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                ),
            new Product(
                new Guid(),
                "Camiseta fem havaianas leblon",
                "",
                129.9,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://havaianas.com.br/dw/image/v2/BDDJ_PRD/on/demandware.static/-/Sites-havaianas-master/default/dwec4e8840/product-images/4149461_0037_CAMISETA-FEM-HAVAIANAS-LEBLON_A.png?sw=680&sh=680", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                ),
            new Product(
                new Guid(),
                "CAMISETA FEMININA BRANCA BEST WINES",
                "",
                189.9,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://cdn.sistemawbuy.com.br/arquivos/a47311a2afa9f9eb2932dc182a3014d4/produtos/65d65c839d42c/camiseta_best_wines_arabesco_207_3_78757b7414f161c7d1f3171995808981-65d66393c5a29.webp", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                ),
            new Product(
                new Guid(),
                "T-shirt Blusa Camiseta Feminina do Brasil Escudo Coração",
                "",
                26.29,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://down-br.img.susercontent.com/file/50172e64431ca162e1d9b660ded3609b", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                ),
            new Product(
                new Guid(),
                "Camiseta taca coração preto",
                "",
                129.9,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://cdn.sistemawbuy.com.br/arquivos/a47311a2afa9f9eb2932dc182a3014d4/produtos/65d65cc6e60c4/camiseta_taca_coracao_preto_125_1_f3b4902b2e5186b2ce4bf6e713ebcb2c-65d66838d3664.webp", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                ),
            new Product(
                new Guid(),
                "Camiseta fem havaianas aloha vibes",
                "",
                129.9,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://havaianas.com.br/dw/image/v2/BDDJ_PRD/on/demandware.static/-/Sites-havaianas-master/default/dw9126436c/product-images/4149460_0046_CAMISETA-FEM-HAVAIANAS-ALOHA-VIBES_A.png?sw=680&sh=680", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                ),
            new Product(
                new Guid(),
                "CAMISETA FEMININA VERDE SILK ROSA",
                "",
                99.8,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://images.tcdn.com.br/img/img_prod/960783/camiseta_feminina_verde_silk_rosa_2173_1_6f610fa5ea86a534613f4689ab134b86.png", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                ),
            new Product(
                new Guid(),
                "Camiseta com letra de música",
                "",
                129.9,
                new List<ImageRef>()
                {
                    new ImageRef(new ImageVO("https://acdn.mitiendanube.com/stores/001/112/372/products/mockup-of-a-woman-wearing-a-crop-top-at-a-studio-319811-81614d16fa25e6654a16482314685366-1024-1024.png", ""))
                },
                new List<ColorRef>()
                {
                    new ColorRef(new ColorVO("#fff"))
                },
                new List<SizeRef>()
                {
                    new SizeRef(new SizeVO("p"))
                },
                new CategoryRef(new CategoryVO("Camisetas")),
                10,
                DateTime.UtcNow,
                DateTime.UtcNow
                )
        };
    }

    [HttpPost]
    [Route("add-product")]
    public async Task<Product> AddProduct([FromBody] Product product)
    {
        try
        {
            _products.Add(product);

            return product;
            //return await _productService.AddProduct(product);
        }
        catch (Exception ex)
        {
            // ...
            throw new Exception();
        }
    }

    [HttpGet]
    [Route("get-product-by-id")]
    public async Task<Product> GetProductById([FromQuery] Guid id)
    {
        try
        {
            return _products[0];

            //return await _productService.GetProductById(id);
        }
        catch (Exception ex)
        {
            // ...
            throw new Exception();
        }
    }

    [HttpGet]
    [Route("get-all-products")]
    public async Task<IList<Product>> GetAllProducts()
    {
        try
        {
            return _products;

            //return await _productService.GetAllProducts();
        }
        catch (Exception ex)
        {
            // ...
            throw new Exception();
        }
    }
}