using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AppDbContext _db;
        public ProductRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u=>u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title= obj.Title;
                objFromDb.ISBN= obj.ISBN;
                objFromDb.Description= obj.Description;
                objFromDb.Price= obj.Price;
                objFromDb.Author= obj.Author;
                objFromDb.Price= obj.Price;
                objFromDb.Price50= obj.Price50;
                objFromDb.Price100= obj.Price100;
                objFromDb.CategoryID= obj.CategoryID;
                objFromDb.CoverTypeID= obj.CoverTypeID;
                if(obj.ImageUrl!=null)
                {
                    objFromDb.ImageUrl= obj.ImageUrl;
                }

            }
        }
    }
}
