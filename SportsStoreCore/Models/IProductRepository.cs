using System.Linq;

namespace SportsStoreCore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
