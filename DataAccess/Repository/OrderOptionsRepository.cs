using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;

namespace DataAccess.Repository
{
    public class OrderOptionsRepository : Repository<OrderOptions>, IOrderOptionsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderOptionsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(OrderOptions orderOptions)
        {
            var obj = _db.OrderOptions.FirstOrDefault(x => x.OrderOptionId == orderOptions.OrderOptionId);
            if (obj != null)
            {
                obj = orderOptions;
            }
        }
    }
}