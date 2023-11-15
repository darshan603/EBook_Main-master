using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;

namespace DataAccess.Repository
{
    public class ProductImagesRepository : Repository<ProductImages>, IProductImagesRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductImagesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ProductImages productImages)
        {
            var obj = _db.ProductImages.FirstOrDefault(x => x.ProdImgId == productImages.ProdImgId);
            if (obj != null)
            {
                obj = productImages;
            }
        }
    }
}