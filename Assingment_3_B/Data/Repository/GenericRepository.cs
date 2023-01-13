using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Assingment_3_B.Data.Repository
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDBContext Context;
        public GenericRepository(AppDBContext context)
        { 
            Context = context; 
        }
        public virtual void Add(TEntity entity)
        {
            Context.Set<TEntity>().AddOrUpdate(entity);
            Context.SaveChanges();
        }
        public virtual void Update(TEntity entity)
        {
            Context.Set<TEntity>().AddOrUpdate();
            Context.SaveChanges();
        }
        public virtual TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }
        public virtual bool Delete(int id)
        {
            bool result = false;
            var entity = Get(id);
            if (entity != null)
            {
                Context.Set<TEntity>().Remove(entity);
                Context.SaveChanges();
                result = true;
            }
            return result;
        }






    }
}