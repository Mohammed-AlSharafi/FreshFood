using FreshFood.Data;
using FreshFood.Interfaces;
using FreshFood.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFood
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FreshFoodContext _context;
        public UnitOfWork(FreshFoodContext context)
        {
            _context = context;
            ProductsRepository = new ProductsRepository(_context);
        }

        public IProductsRepository ProductsRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
