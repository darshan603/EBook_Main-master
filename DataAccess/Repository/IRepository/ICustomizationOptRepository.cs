using Models;

namespace DataAccess.Repository.IRepository
{
    public interface ICustomizationOptRepository : IRepository<CustomizationOpt>
    {
        void Update(CustomizationOpt customizationOpt);
    }
}