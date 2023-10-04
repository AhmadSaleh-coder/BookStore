﻿using BulkyBook.DataAccess.Repository.IRepository;


namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db= db;
            Category = new CategoryRepository(_db);
            CoverType= new CoverTypeRepository(_db);
            Product= new ProductRepository(_db);
        }
        public ICategeryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
