using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;

namespace DataAccess.Repository
{
    public class CustomizationOptRepository : Repository<CustomizationOpt>, ICustomizationOptRepository
    {
        private readonly ApplicationDbContext _db;

        public CustomizationOptRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CustomizationOpt customizationOpt)
        {
            var obj = _db.CustomizationOpt.FirstOrDefault(x => x.OptionId == customizationOpt.OptionId);
            if (obj != null)
            {
                obj = customizationOpt;
            }
        }
    }
}