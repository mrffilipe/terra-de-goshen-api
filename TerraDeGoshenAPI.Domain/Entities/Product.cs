namespace TerraDeGoshenAPI.Domain;

public class Product : IEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }
    public IList<ImageRef>? Images { get; private set; }
    public IList<ColorRef>? Colors { get; private set; }
    public IList<SizeRef>? Sizes { get; private set; }
    public CategoryRef Category { get; private set; }
    public int QuantityInStock { get; private set; }

    public Product(
        string name,
        string description,
        double price,
        IList<ImageRef> images,
        IList<ColorRef> colors,
        IList<SizeRef> sizes,
        CategoryRef category,
        int quantityInStock
        )
    {
        UpdateName(name);
        UpdateDescription(description);
        UpdatePrice(price);
        UpdateImages(images);
        Colors = colors;
        Sizes = sizes;
        Category = category;
        UpdateQuantity(quantityInStock);
    }

    public Product(
        Guid id,
        string name,
        string description,
        double price,
        IList<ImageRef> images,
        IList<ColorRef> colors,
        IList<SizeRef> sizes,
        CategoryRef category,
        int quantityInStock,
        DateTime createdAt,
        DateTime updatedAt
        ) : this(name, description, price, images, colors, sizes, category, quantityInStock)
    {
        Id = id;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    public void UpdateName(string name)
    {
        if (name.Length > 0)
        {
            Name = name;
        }
        else
        {
            // erro
        }
    }

    public void UpdateDescription(string description)
    {
        if (description.Length > 0 || description != null)
        {
            Description = description;
        }
        else
        {
            // erro
        }
    }

    public void UpdatePrice(double value)
    {
        if (value > 0)
        {
            Price = value;
        }
        else
        {
            // erro
        }
    }

    public void UpdateImages(IList<ImageRef> images)
    {
        if (images != null) // lógica
        {
            Images = images;
        }
        else
        {
            // erro
        }
    }

    public void UpdateColors(IList<ColorRef> colors)
    {
        if (colors != null)
        {
            Colors = colors;
        }
        else
        {
            // erro
        }
    }

    public void UpdateSizes(IList<SizeRef> sizes)
    {
        if (sizes != null)
        {
            Sizes = sizes;
        }
        else
        {
            // erro
        }
    }

    public void UpdateCategory(CategoryRef category)
    {
        Category = category;
    }

    public void UpdateQuantity(int value)
    {
        if (QuantityInStock > 0 && value > 0)
        {
            QuantityInStock += value;
        }
        else
        {
            // erro
        }
    }
}