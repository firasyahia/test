using Ski.Data.Infrastructures;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Pattern
{
    public class Service<T> : IService<T> where T: class
    {
        private UnitOfWork utw;
        public Service(UnitOfWork utw)
        {
            this.utw = utw;
        }

        public void Commit()
        {
            utw.commit();
        }

        public virtual void Create(T entity)
        {
            utw.GetRepository<T>().Add(entity);
        }

        public virtual T GetById(string id)
        {
            return utw.GetRepository<T>().GetById(id);
        }

        public virtual T GetById(int id)
        {
            return utw.GetRepository<T>().GetById(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderby = null)
        {
            return utw.GetRepository<T>().GetMany(condition,orderby);
        }

        public virtual void Remove(Expression<Func<T, bool>> condition)
        {
             utw.GetRepository<T>().Delete(condition);
        }

        public virtual void Remove(T entity)
        {
            utw.GetRepository<T>().Delete(entity);
        }

        public virtual void Update(T entity)
        {
            utw.GetRepository<T>().Update(entity);
        }
    }
}
