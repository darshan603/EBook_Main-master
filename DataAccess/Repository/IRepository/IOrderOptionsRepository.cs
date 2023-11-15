using Models;

namespace DataAccess.Repository.IRepository
{
    public interface IOrderOptionsRepository : IRepository<OrderOptions>
    {
        void Update(OrderOptions orderOptions);
    }
}