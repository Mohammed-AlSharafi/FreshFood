using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFood.Interfaces
{
    public interface IRepository <TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll ();

        TEntity Get (int id);
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
