using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        T Get();
        List<T> GetAllByCategory(int categoryId);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
