using BA_Project.DAL.Interfaces;
using System.Linq.Expressions;

namespace BA_Project.Business.Interfaces
{
    public interface IManager<T> where T : IEntity
    {
        public void Add(T entity);
        public void Remove(T entity);
        public List<T> Get(Expression<Func<T, bool>> predicate);
        public bool Exists(Expression<Func<T, bool>> predicate);
    }
}
