using Models;

namespace DataAccess.Repository.IRepository
{
    public interface IProductImagesRepository : IRepository<ProductImages>
    {
        void Update(ProductImages productImages);
    }
}