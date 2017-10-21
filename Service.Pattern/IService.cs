using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Pattern
{
    public interface IService<T> where T : class
    {
        void Create(T entity);
        void Remove(T entity);

        void Update(T entity);
        T GetById(int id);
        T GetById(string id);

        //IEnumerable <T> GetAll();
        //bool type de resultat pas l'expression
        IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderby = null);
        void Remove(Expression<Func<T, bool>> condition);
        void Commit();
    }
}
